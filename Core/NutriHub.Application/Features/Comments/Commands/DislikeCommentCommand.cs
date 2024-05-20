using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Comments.Commands
{
    public class DislikeCommentCommand : IRequest
    {
        public int CommentId { get; set; }
    }
}
