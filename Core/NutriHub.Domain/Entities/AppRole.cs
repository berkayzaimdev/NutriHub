﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Domain.Entities
{
    public class AppRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<AppUser> Users { get; set; }
    }
}