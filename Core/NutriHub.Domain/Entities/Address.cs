using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
