using NutriHub.Business.Services;
using NutriHub.Dto.BrandDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Business.Managers
{
    public class BrandManager : GenericService<ResultBrandDto, CreateBrandDto, UpdateBrandDto>, IBrandService
    {
        public BrandManager(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            SetEndpoint("Brands");
        }

        public async Task CreateAsync(CreateBrandDto createDto)
        {
            await base.CreateAsync(createDto);
        }
    }
}
