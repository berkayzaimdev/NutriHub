﻿using MediatR;
using NutriHub.Application.Abstractions.Interfaces.CommentInterfaces;
using NutriHub.Application.Features.Queries.CommentQueries;
using NutriHub.Application.Features.Results.CommentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Handlers.CommentHandlers
{
    public class GetAllCommentsByProductIdQueryHandler : IRequestHandler<GetAllCommentsByProductIdQuery, IEnumerable<GetAllCommentsByProductIdQueryResult>>
    {
        private readonly ICommentRepository _repository;

        public GetAllCommentsByProductIdQueryHandler(ICommentRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<GetAllCommentsByProductIdQueryResult>> Handle(GetAllCommentsByProductIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllCommentsByProductIdAsync(request.ProductId);
            return values.Select(x => new GetAllCommentsByProductIdQueryResult
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
