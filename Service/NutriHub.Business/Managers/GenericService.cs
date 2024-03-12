using Newtonsoft.Json;
using NutriHub.Business.Services;
using NutriHub.Dto.BrandDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Business.Managers
{
    public class GenericService<TDto, TCreateDto, TUpdateDto> : IGenericService<TDto, TCreateDto, TUpdateDto>
        where TDto : class
        where TCreateDto : class
        where TUpdateDto : class
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private string _endpoint;

        public GenericService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task CreateAsync(TCreateDto createDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync($"https://localhost:7049/api/{_endpoint}", stringContent);
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception();
            }
        }

        public async Task<List<TDto>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task RemoveAsync()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(TUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }

        public void SetEndpoint(string endpoint) 
        {
            _endpoint = endpoint;
        }
    }
}
