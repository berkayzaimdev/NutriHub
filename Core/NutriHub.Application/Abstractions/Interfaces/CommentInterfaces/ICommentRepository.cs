using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Abstractions.Interfaces.CommentInterfaces
{
    public interface ICommentRepository 
    {
        Task<List<Comment>> GetAllCommentsByProductIdAsync(string productId);
        Task<List<Comment>> GetAllCommentsByAppUserIdAsync(string appUserId);
    }
}
