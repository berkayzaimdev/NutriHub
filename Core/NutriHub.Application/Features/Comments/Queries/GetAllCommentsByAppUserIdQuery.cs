using MediatR;
using NutriHub.Application.Features.Comments.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Comments.Queries
{
    public class GetAllCommentsByUserIdQuery : IRequest<IEnumerable<GetAllCommentsByUserIdQueryResult>>
    {
        public string UserId { get; set; }

        public GetAllCommentsByUserIdQuery(string UserId)
        {
            UserId = UserId;
        }
    }
}
