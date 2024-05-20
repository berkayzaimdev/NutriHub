using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Comments.Commands
{
    public class CreateCommentCommand : IRequest
    {
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public decimal Rating { get; set; }

        public CreateCommentCommand(string userId, int productId, string description, decimal rating)
        {
            UserId = userId;
            ProductId = productId;
            Description = description;
            Rating = rating;
        }
    }
}
