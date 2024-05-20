using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Comments.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Comments.Handlers
{
    public class LikeCommentCommandHandler : IRequestHandler<LikeCommentCommand>
    {
        private readonly ICommentRepository _repository;

        public LikeCommentCommandHandler(ICommentRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(LikeCommentCommand request, CancellationToken cancellationToken)
        {
            await _repository.LikeCommentAsync(request.CommentId);
        }
    }
}
