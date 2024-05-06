using Microsoft.EntityFrameworkCore;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Abstractions.Interfaces.CommentInterfaces;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.Repositories.CommentRepositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly IRepository<Comment> _repository;

        public CommentRepository(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Comment>> GetAllCommentsByAppUserIdAsync(string appUserId)
        {
            var values = await _repository.GetAllAsync();
            values = values.Where(x => x.AppUserId == appUserId);
            return values;
        }

        public async Task<IEnumerable<Comment>> GetAllCommentsByProductIdAsync(int productId)
        {
            var values = await _repository.GetAllAsync();
            values = values.Where(x => x.ProductId == productId);
            return values;
        }
    }
}
