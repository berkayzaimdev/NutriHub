using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Products.Commands
{
    public class RemoveProductCommand
    {
        public int Id { get; set; }

        public RemoveProductCommand(int id)
        {
            Id = id;
        }
    }
}
