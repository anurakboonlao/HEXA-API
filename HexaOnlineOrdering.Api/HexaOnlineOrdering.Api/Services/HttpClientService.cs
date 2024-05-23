using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Api.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services
{
    public class HttpClientService : IHttpClientService
    {
        private readonly HttpClient _httpClient;

        public HttpClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task DeleteAsync(string url)
        {
            try
            {
                var response = await _httpClient.DeleteAsync(url);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw;
            }
        }

        public async Task<T> GetAsync<T>(string url)
        {
            try
            {
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var responseStream = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<T>(responseStream);
                return result;
            }
            catch (HttpRequestException ex)
            {

                throw;
            }
        }

        public async Task<T> PostAsync<T, U>(string url, U payload)
        {
            try
            {
                string json = JsonConvert.SerializeObject(payload);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(url, httpContent);
                response.EnsureSuccessStatusCode();

                var responseStream = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<T>(responseStream);
                return result;
            }
            catch (HttpRequestException ex)
            {

                throw;
            }
            
        }

        public async Task<T> PutAsync<T, U>(string url, U payload)
        {
            try
            {
                string json = JsonConvert.SerializeObject(payload);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync(url, httpContent);
                response.EnsureSuccessStatusCode();

                var responseStream = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<T>(responseStream);
                return result;
            }
            catch (HttpRequestException ex)
            {

                throw;
            }
        }
    }
}
