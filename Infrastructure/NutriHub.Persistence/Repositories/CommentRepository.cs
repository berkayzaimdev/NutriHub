﻿using Microsoft.EntityFrameworkCore;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly IRepository<Comment> _repository;

        public CommentRepository(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Comment>> GetAllCommentsByUserIdAsync(string UserId)
        {
            var values = await _repository.GetAllAsync();
            values = values.Where(x => x.UserId == UserId);
            return values;
        }

        public async Task<IEnumerable<Comment>> GetAllCommentsByProductIdAsync(int productId)
        {
            var values = await _repository.GetAllAsync();
            values = values.Where(x => x.ProductId == productId).Include(x => x.User);
            return values;
        }

        public async Task LikeCommentAsync(int commentId)
        {
            var value = await _repository.GetAsync(commentId);
            value.Like++;
            await _repository.UpdateAsync(value);
        }

        public async Task DislikeCommentAsync(int commentId)
        {
            var value = await _repository.GetAsync(commentId);
            value.Dislike++;
            await _repository.UpdateAsync(value);
        }
    }
}
