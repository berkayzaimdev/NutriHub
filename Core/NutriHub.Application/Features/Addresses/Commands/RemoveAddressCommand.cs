using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Addresses.Commands
{
    public class RemoveAddressCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveAddressCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
