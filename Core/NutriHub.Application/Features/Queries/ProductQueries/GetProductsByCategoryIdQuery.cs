using MediatR;
using NutriHub.Application.Features.Results.ProductResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Queries.ProductQueries
{
    public class GetProductsByCategoryIdQuery : IRequest<List<GetProductsByCategoryIdQueryResult>>
    {
        public int CategoryId { get; set; }
        public GetProductsByCategoryIdQuery(int categoryId)
        {
            CategoryId = categoryId;
        }
    }
}
