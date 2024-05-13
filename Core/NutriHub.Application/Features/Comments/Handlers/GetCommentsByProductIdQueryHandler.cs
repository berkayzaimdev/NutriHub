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
    public class GetCommentsByProductIdQueryHandler : IRequestHandler<GetCommentsByProductIdQuery, IEnumerable<GetCommentsByProductIdQueryResult>>
    {
        private readonly ICommentRepository _repository;

        public GetCommentsByProductIdQueryHandler(ICommentRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<GetCommentsByProductIdQueryResult>> Handle(GetCommentsByProductIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllCommentsByProductIdAsync(request.ProductId);
            return values.Select(x => new GetCommentsByProductIdQueryResult
            {
                CommentId = x.Id,

                UserId = x.User.Id,
                UserName = x.User.UserName,

                CreatedDate = x.CreatedDate,
                Description = x.Description,
                Like = x.Like,
                Dislike = x.Dislike,
            });
        }
    }
}
