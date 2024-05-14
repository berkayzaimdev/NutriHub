using MediatR;
using NutriHub.Application.Features.Brands.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Brands.Queries
{
    public class GetBrandsMenuQuery : IRequest<IEnumerable<GetBrandsMenuQueryResult>>
    {
    }
}
