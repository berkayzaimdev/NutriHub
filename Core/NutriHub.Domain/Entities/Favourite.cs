﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Domain.Entities
{
    public class Favourite
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string AppUserId { get; set; }
        public Product Product { get; set; }
        public AppUser AppUser { get; set; }
    }
}
