using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.DTOs.OrderDtos
{
    public class CreateOrderDto
    {
        public PaymentMethod PaymentMethod { get; set; }
        public string Note { get; set; }
        public decimal ShippingAmount { get; set; }
        public int AddressId { get; set; }
    }
}
