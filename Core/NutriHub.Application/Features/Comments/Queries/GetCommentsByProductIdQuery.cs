using MediatR;
using NutriHub.Application.Features.Comments.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Comments.Queries
{
    public class GetCommentsByProductIdQuery : IRequest<IEnumerable<GetCommentsByProductIdQueryResult>>
    {
        public int ProductId { get; set; }

        public GetCommentsByProductIdQuery(int productId)
        {
            ProductId = productId;
        }
    }
}
