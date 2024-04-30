using MediatR;
using NutriHub.Application.Features.Results.CommentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Queries.CommentQueries
{
    public class GetAllCommentsByAppUserIdQuery : IRequest<List<GetAllCommentsByAppUserIdQueryResult>>
    {
        public int AppUserId { get; set; }

        public GetAllCommentsByAppUserIdQuery(int appUserId)
        {
            AppUserId = appUserId;
        }
    }
}
