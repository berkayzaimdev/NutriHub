﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Domain.Entities
{
    public class Coupon
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public decimal Discount { get; set; }
    }
}
