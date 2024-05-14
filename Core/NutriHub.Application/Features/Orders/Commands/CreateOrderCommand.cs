using MediatR;
using Newtonsoft.Json;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Orders.Commands
{
    public class CreateOrderCommand : IRequest
    {
        public PaymentMethod PaymentMethod { get; set; }
        public string Note { get; set; }
        public decimal ShippingAmount { get; set; }
        public int AddressId { get; set; }

        public string UserId { get; set; }
    }
}
