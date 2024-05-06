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
        public string AppUserId { get; set; }

        public GetAllCommentsByAppUserIdQuery(string appUserId)
        {
            AppUserId = appUserId;
        }
    }
}
