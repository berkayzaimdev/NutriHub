using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Domain.Entities;
using NutriHub.Persistence.EFCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(NutriHubContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Address>> GetAddressesByUserIdAsync(string userId)
        {
            var values = await GetAllAsync();
            return values.Where(x => x.UserId == userId);   
        }
    }
}
