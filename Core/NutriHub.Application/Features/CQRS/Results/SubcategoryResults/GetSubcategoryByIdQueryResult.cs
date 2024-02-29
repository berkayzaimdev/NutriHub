using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.CQRS.Results.SubcategoryResults
{
    public class GetSubcategoryByIdQueryResult
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
