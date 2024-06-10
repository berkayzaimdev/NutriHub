using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Subcategories.Commands
{
    public class RemoveSubcategoryCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveSubcategoryCommand(int id)
        {
            Id = id;
        }
    }
}
