using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Domain.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Favourite> Favourites { get; set; }
        public IEnumerable<CartItem> CartItems { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
