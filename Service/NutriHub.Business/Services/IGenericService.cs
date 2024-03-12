using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Business.Services
{
    public interface IGenericService<TDto, TCreateDto, TUpdateDto>
        where TDto : class
        where TCreateDto : class
        where TUpdateDto : class
    {
        Task<List<TDto>> GetAsync();
        Task CreateAsync(TCreateDto createDto);
        Task UpdateAsync(TUpdateDto updateDto);
        Task RemoveAsync(int id);
        void SetEndpoint(string endpoint);
    }
}
