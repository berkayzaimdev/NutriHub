using MediatR;
using NutriHub.Application.Features.Results.ProductResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Products.Queries
{
    public class GetProductByIdQuery : IRequest<GetProductByIdQueryResult>
    {
        public int Id { get; set; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
