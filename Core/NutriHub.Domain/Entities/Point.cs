using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Domain.Entities
{
    public class Point
    {
        public string UserId { get; set; }
        public int Points { get; set; } = 0;
    }
}
