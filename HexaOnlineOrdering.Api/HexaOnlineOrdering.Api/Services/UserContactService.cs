using System;
using System.Threading.Tasks;
using AutoMapper;
using HexaOnlineOrdering.Api.Exceptions;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Repositories.DataModels;
using HexaOnlineOrdering.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace HexaOnlineOrdering.Api.Services
{
    public class UserContactService : IUserContactService
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<UserContactService> _logger;
        private readonly IMapper _mapper;

        public UserContactService(IUserRepository userRepository, ILogger<UserContactService> logger, IMapper mapper)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<int> CreateUserContact(UserModel userContact)
        {
            var newContact = _mapper.Map<UserModel, TblUser>(userContact);
            newContact.CreateAt = DateTime.Now;
            newContact.LastUpdate = DateTime.Now;
            await _userRepository.AddAsync(newContact);
            await _userRepository.CommitAsync();
            return newContact.UserId;
        }

        public async Task<UserModel> GetUserContactById(int contactId )
        {
            var userContact = await _userRepository.GetAsync(c => c.ContactId == contactId);
            return _mapper.Map<TblUser, UserModel>(userContact);
        }

        public async Task UpdateUserContact(UserModel userContact)
        {
            var contact = await _userRepository.GetAsync(c => c.ContactId == userContact.ContactId);
            if (contact == null)
                throw new HexaDomainException($"User contact id {userContact.ContactId} cannot be found");

            contact = _mapper.Map(userContact, contact);
            contact.LastUpdate = DateTime.Now;

            _userRepository.Update(contact);
            await _userRepository.CommitAsync();
        }
    }
}
