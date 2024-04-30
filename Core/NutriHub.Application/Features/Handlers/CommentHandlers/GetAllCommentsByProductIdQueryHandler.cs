using MediatR;
using NutriHub.Application.Features.Queries.CommentQueries;
using NutriHub.Application.Features.Results.CommentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Handlers.CommentHandlers
{
    public class GetAllCommentsByProductIdQueryHandler : IRequestHandler<GetAllCommentsByProductIdQuery, List<GetAllCommentsByProductIdQueryResult>>
    {
        private readonly ICommentRepository _commentRepository;
        public Task<List<GetAllCommentsByProductIdQueryResult>> Handle(GetAllCommentsByProductIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
