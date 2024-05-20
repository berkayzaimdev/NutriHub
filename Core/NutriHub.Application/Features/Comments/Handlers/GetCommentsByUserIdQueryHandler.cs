using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Comments.Queries;
using NutriHub.Application.Features.Comments.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Comments.Handlers
{
    public class GetCommentsByUserIdQueryHandler : IRequestHandler<GetCommentsByUserIdQuery, IEnumerable<GetCommentsByUserIdQueryResult>>
    {
        private readonly ICommentRepository _repository;

        public GetCommentsByUserIdQueryHandler(ICommentRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<GetCommentsByUserIdQueryResult>> Handle(GetCommentsByUserIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllCommentsByUserIdAsync(request.UserId);
            return values.Select(x => new GetCommentsByUserIdQueryResult
            {
                CommentId = x.Id,

                CreatedDate = x.CreatedDate,
                Description = x.Description,
                Like = x.Like,
                Dislike = x.Dislike,
            });
        }
    }
}
