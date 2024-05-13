using MediatR;
using NutriHub.Application.Features.Comments.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Comments.Queries
{
    public class GetAllCommentsByProductIdQuery : IRequest<IEnumerable<GetAllCommentsByProductIdQueryResult>>
    {
        public int ProductId { get; set; }

        public GetAllCommentsByProductIdQuery(int productId)
        {
            ProductId = productId;
        }
    }
}
