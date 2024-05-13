using MediatR;
using NutriHub.Application.Features.Products.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Products.Queries
{
    public class GetProductDetailQuery : IRequest<GetProductDetailQueryResult>
    {
        public int ProductId { get; set; }
        public string UserId { get; set; }

        public GetProductDetailQuery(int productId, string userId)
        {
            ProductId = productId;
            UserId = userId;
        }
    }
}
