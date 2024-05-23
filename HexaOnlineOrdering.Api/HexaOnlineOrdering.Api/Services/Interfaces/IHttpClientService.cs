using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface IHttpClientService
    {
        Task<T> GetAsync<T>(string url);

        Task<T> PostAsync<T, U>(string url, U payload);

        Task DeleteAsync(string url);

        Task<T> PutAsync<T, U>(string url, U payload);
    }
}
