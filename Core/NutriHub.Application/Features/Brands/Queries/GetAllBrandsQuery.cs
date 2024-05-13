using MediatR;
using NutriHub.Application.Features.Brands.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Queries.BrandQueries
{
    public class GetAllBrandsQuery : IRequest<IEnumerable<GetAllBrandsQueryResult>>
    {
    }
}
