using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Api.Options;
using HexaOnlineOrdering.Api.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using HexaOnlineOrdering.Models.Marketing;
using HexaOnlineOrdering.Api.Exceptions;
using HexaOnlineOrdering.Api.Filters;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HexaOnlineOrdering.Api.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : BaseController
    {

        private readonly JWTSetting _jwtOption;
        private readonly MarketingSetting _marketingOption;
        private readonly IUserService _userService;
        private readonly INetforceService _netForceService;
        private readonly IUserContactService _userContactService;
        private readonly IMarketingService _marketingService;

        public AccountController(IHttpContextAccessor httpContextAccessor, IUserService userService, INetforceService netForceService, IUserContactService userContactService, IMarketingService marketingService, IOptions<JWTSetting> jwtOptions, IOptions<MarketingSetting> marketingOptions) : base(httpContextAccessor)
        {
            _jwtOption = jwtOptions.Value;
            _marketingOption = marketingOptions.Value;
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _netForceService = netForceService ?? throw new ArgumentNullException(nameof(netForceService));
            _userContactService = userContactService ?? throw new ArgumentNullException(nameof(userContactService));
            _marketingService = marketingService ?? throw new ArgumentNullException(nameof(marketingService));
        }

        [HttpGet("info")]
        [Authorize()]
        public IActionResult UserInfo()
        {
            return Ok(HttpContext.User.Claims);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginModel user)
        {
            var exitingUser = await _userService.LoginUser(user.Username, user.Password);
            if (exitingUser != null && exitingUser.Role != "Clinic" && exitingUser.Role != "Dentist")
            {
                // Get references doctors or clinics with user model from ERP api if Role = Dentist, Clinic.
                if (exitingUser.Role == "Clinic")
                {
                    if (exitingUser.ContactId.HasValue)
                    {
                        var clinic = await _netForceService.GetContactByIdAsync(exitingUser.ContactId.Value);
                        if (clinic != null)
                        {
                            var doctors = await _netForceService.GetDoctorByIdsAsync(clinic.DoctorIds);
                            exitingUser.Doctors = doctors.Select(q => new DoctorContactModel() { DoctorId = q.Id, Name = q.Name }).ToList();
                        }
                    }
                }
                else if (exitingUser.Role == "Dentist")
                {
                    if (exitingUser.ContactId.HasValue)
                    {
                        var dentist = await _netForceService.GetDoctorByIdAsync(exitingUser.ContactId.Value);
                        if (dentist != null)
                        {
                            var clinics = await _netForceService.GetContactByIdsAsync(dentist.ContactIds);
                            exitingUser.Clinics = clinics.Select(q => new ClinicContactModel() { ClinicId = q.Id, Name = q.Name }).ToList();
                        }
                    }
                }
                string token = GenerateJSONWebToken(exitingUser);
                return Ok(new AuthModel() { Token = token });
            }

            return StatusCode((int)HttpStatusCode.Forbidden, new { message = "Username or password is not correct.", error = "Wrong credentials" });
        }

        [HttpPost("logincookie")]
        public async Task<IActionResult> LoginCookie([FromBody] UserLoginModel user)
        {
            if (user.Username == "tan" && user.Password == "1234")
            {
                List<Claim> claims = new List<Claim>{
                                    new Claim(ClaimTypes.Name, user.Username)
                                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    new AuthenticationProperties
                    {
                        IsPersistent = false,
                        ExpiresUtc = DateTime.UtcNow.AddMinutes(5)
                    });
            }


            return Unauthorized();
        }

        [HttpPost("logout")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Ok();
        }

        [CustomAuthorization]
        [HttpPost("externallogin")]
        public async Task<IActionResult> ExternalLogin([FromBody] MarketingLoginModel marketingLoginModel)
        {
            var marketingMember = await _marketingService.GetMemberByCustomerIdAndType(marketingLoginModel.ContactId, marketingLoginModel.Type);
            if (marketingMember == null)
                throw new HexaDomainException("User cannot be found");

            UserModel userContact = await _userContactService.GetUserContactById(marketingLoginModel.ContactId);

            if (marketingLoginModel.Type == "clinic")
            {
                var clinic = await _netForceService.GetContactByIdAsync(marketingLoginModel.ContactId);
                if (clinic == null)
                    throw new HexaDomainException("User cannot be found");

                if (userContact == null)
                {
                    userContact = new UserModel();
                    userContact.Active = clinic.Active;
                    userContact.ContactId = clinic.Id;
                    userContact.Name = clinic.Name;
                    userContact.UserRoleId = 2;
                    userContact.UserId = await _userContactService.CreateUserContact(userContact);
                }
                else
                {
                    // Fetch new profile info from ERP is it's out of date fro 30 days.
                    if (DateTime.Now.Subtract(userContact.LastUpdate).Days >= 30)
                    {
                        userContact.Name = clinic.Name;
                        await _userContactService.UpdateUserContact(userContact);
                    }

                    //var issuer = await CreateIssuer(marketingLoginModel);
                }

                // var doctors = await _netForceService.GetDoctorByIdsAsync(clinic.DoctorIds);
                // userContact.Doctors = doctors.Select(q => new DoctorContactModel() { DoctorId = q.Id, Name = q.Name }).ToList();
                userContact.Role = "Clinic";
            }
            else if (marketingLoginModel.Type == "doctor")
            {
                var dentist = await _netForceService.GetDoctorByIdAsync(marketingLoginModel.ContactId);
                if (dentist == null)
                    throw new HexaDomainException("User cannot be found");

                if (userContact == null)
                {
                    userContact = new UserModel();
                    userContact.Active = dentist.Active;
                    userContact.ContactId = dentist.Id;
                    userContact.Name = dentist.Name;
                    userContact.UserRoleId = 1;
                    userContact.UserId = await _userContactService.CreateUserContact(userContact);
                }
                else
                {
                    // Fetch new profile info from ERP is it's out of date fro 30 days.
                    if (DateTime.Now.Subtract(userContact.LastUpdate).Days >= 30)
                    {
                        userContact.Name = dentist.Name;
                        await _userContactService.UpdateUserContact(userContact);
                    }

                    //issuer = await CreateIssuer(marketingLoginModel);
                }

                //var clinics = await _netForceService.GetContactByIdsAsync(dentist.ContactIds);
                //userContact.Clinics = clinics.Select(q => new ClinicContactModel() { ClinicId = q.Id, Name = q.Name }).ToList();
                userContact.Role = "Dentist";
            }

            userContact.UserId = userContact.UserId;
            userContact.Name = userContact.Name;
            userContact.DisplayPicture = string.Concat(_marketingOption.WebUrl, _marketingOption.PicturePath, marketingMember.Image);// $"{_marketingOption.WebUrl}/{_marketingOption.PicturePath}/{marketingMember.Image}";

            string token = GenerateJSONWebToken(userContact);
            return Ok(new AuthModel() { Token = token });
        }

        [HttpGet("subcontact")]
        [Authorize(Roles = "Dentist, Clinic")]
        public async Task<SubContactModel> GetSubContact()
        {
            ClaimsIdentity identity = HttpContext.User.Identity as ClaimsIdentity;
            SubContactModel result = new SubContactModel();
            if (identity != null)
            {
                IEnumerable<Claim> claims = identity.Claims;
                int contactId = 0;
                int.TryParse(claims.First(c => c.Type == "ContactId").Value, out contactId);
                string role = getMarketingLoginType(claims.First(c => c.Type == ClaimTypes.Role).Value);

                var marketingMember = await _marketingService.GetMemberByCustomerIdAndType(contactId, role);
                if (marketingMember == null)
                    throw new HexaDomainException("User cannot be found");

                UserModel userContact = await _userContactService.GetUserContactById(contactId);
                if (userContact == null)
                {
                    throw new HexaDomainException("No User in table because wrong flow must call externallogin");
                }
                if (role == "clinic")
                {
                    var clinic = await _netForceService.GetContactByIdAsync(contactId);
                    if (clinic == null)
                        throw new HexaDomainException("Clinic cannot be found");

                    var doctors = await _netForceService.GetDoctorByIdsAsync(clinic.DoctorIds);
                    result.Doctors = doctors.Select(q => new DoctorContactModel() { DoctorId = q.Id, Name = q.Name }).ToList();
                }
                else if (role == "doctor")
                {
                    var dentist = await _netForceService.GetDoctorByIdAsync(contactId);
                    if (dentist == null)
                        throw new HexaDomainException("Doctor cannot be found");

                    var clinics = await _netForceService.GetContactByIdsAsync(dentist.ContactIds);
                    result.Clinics = clinics.Select(q => new ClinicContactModel() { ClinicId = q.Id, Name = q.Name }).ToList();
                }

                return result;
            }

            throw new HexaDomainException("Unauthorized token no Claims");
        }

        [HttpGet("alive")]
        [Authorize(Roles = "Dentist, Clinic")]
        public IActionResult Alive()
        {
            return Ok($"You are a live {CurrentUserId}");
        }

        #region Private Methods
        private string GenerateJSONWebToken(UserModel userInfo)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_jwtOption.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("Id", userInfo.UserId.ToString()),
                    new Claim(JwtRegisteredClaimNames.Sub, userInfo.Name),
                    new Claim(ClaimTypes.Role, GetMainRole(userInfo.Role)),
                    new Claim("CustomRole", userInfo.Role),
                    new Claim("AdminProductType", userInfo.AdminProductTypeId != null ? string.Format("[{0}]" ,string.Join(",",userInfo.AdminProductTypeId)) : string.Empty,JsonClaimValueTypes.JsonArray),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim("Doctors", JsonConvert.SerializeObject(userInfo.Doctors ?? new List<DoctorContactModel>()) ,JsonClaimValueTypes.JsonArray),
                    new Claim("Clinics",  JsonConvert.SerializeObject(userInfo.Clinics ?? new List<ClinicContactModel>()) ,JsonClaimValueTypes.JsonArray),
                    new Claim("ContactId", userInfo.ContactId.HasValue ? userInfo.ContactId.Value.ToString() : ""),
                    new Claim("DisplayImage", userInfo.DisplayPicture ?? "")
                }),
                Expires = DateTime.Now.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Audience = _jwtOption.Audience,
                Issuer = _jwtOption.Issuer
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);

            return jwtToken;
        }

        private string GetMainRole(string role)
        {
            if (role != "Dentist" && role != "Clinic" && role != "Admin")
                return "Staff";
            return role;
        }

        private string GenerateJSONWebToken2(UserModel userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOption.Secret));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, userInfo.Username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(_jwtOption.Issuer,
                _jwtOption.Audience,
                claims,
                expires: DateTime.Now.AddDays(7),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private async Task<UserModel> CreateIssuer(MarketingLoginModel marketingLoginModel)
        {
            UserModel issuer = new UserModel();
            if (marketingLoginModel.Type == "clinic")
            {
                // Call ERP service.
                var clinic = await _netForceService.GetContactByIdAsync(marketingLoginModel.ContactId);
                if (clinic == null)
                    throw new HexaDomainException("User is not exist");

                var doctors = await _netForceService.GetDoctorByIdsAsync(clinic.DoctorIds);
                issuer.Doctors = doctors.Select(q => new DoctorContactModel() { DoctorId = q.Id, Name = q.Name }).ToList();

            }
            else if (marketingLoginModel.Type == "doctor")
            {
                // Call ERP service.
                var dentist = await _netForceService.GetDoctorByIdAsync(marketingLoginModel.ContactId);
                if (dentist == null)
                    throw new HexaDomainException("User is not exist");

                var clinics = await _netForceService.GetContactByIdsAsync(dentist.ContactIds);
                issuer.Clinics = clinics.Select(q => new ClinicContactModel() { ClinicId = q.Id, Name = q.Name }).ToList();
            }

            return issuer;
        }

        private string getMarketingLoginType(string tokenRole)
        {
            if (tokenRole == "Clinic")
                return "clinic";
            if (tokenRole == "Dentist")
                return "doctor";
            return string.Empty;
        }

        #endregion
    }

}
