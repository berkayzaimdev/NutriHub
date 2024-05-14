using MediatR;
using NutriHub.Application.Features.Comments.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Comments.Queries
{
    public class GetCommentsByUserIdQuery : IRequest<IEnumerable<GetCommentsByUserIdQueryResult>>
    {
        public string UserId { get; set; }

        public GetCommentsByUserIdQuery(string userId)
        {
            UserId = userId;
        }
    }
}
