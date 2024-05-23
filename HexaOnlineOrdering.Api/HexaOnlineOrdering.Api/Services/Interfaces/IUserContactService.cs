using System;
using System.Threading.Tasks;
using HexaOnlineOrdering.Models;

namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface IUserContactService
    {
        Task<int> CreateUserContact(UserModel userContact);

        Task UpdateUserContact(UserModel userContact);

        Task<UserModel> GetUserContactById(int contactId);

    }
}
