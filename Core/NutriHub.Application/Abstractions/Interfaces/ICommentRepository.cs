using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Abstractions.Interfaces
{
    public interface ICommentRepository
    {
        Task<IEnumerable<Comment>> GetAllCommentsByProductIdAsync(int productId);
        Task<IEnumerable<Comment>> GetAllCommentsByUserIdAsync(string UserId);
        Task LikeCommentAsync(int commentId);
        Task DislikeCommentAsync(int commentId);
    }
}
