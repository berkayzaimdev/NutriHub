using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly IRepository<Address> _repository;

        public AddressRepository(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Address>> GetAddressesByUserIdAsync(string userId)
        {
            var values = await _repository.GetAllAsync();
            return values.Where(x => x.UserId == userId);   
        }
    }
}
