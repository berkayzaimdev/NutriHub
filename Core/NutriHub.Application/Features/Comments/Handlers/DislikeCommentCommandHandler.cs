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
    public class DislikeCommentCommandHandler : IRequestHandler<DislikeCommentCommand>
    {
        private readonly ICommentRepository _repository;

        public DislikeCommentCommandHandler(ICommentRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(DislikeCommentCommand request, CancellationToken cancellationToken)
        {
            await _repository.DislikeCommentAsync(request.CommentId);
        }
    }
}
