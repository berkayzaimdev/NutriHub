using MediatR;
using NutriHub.Application.Features.Results.CommentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Queries.CommentQueries
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
