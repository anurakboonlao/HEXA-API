using System;
namespace HexaOnlineOrdering.Models
{
    public class UpdateUserModel : UserModel
    {
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
