using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Results.CommentResults
{
    public class GetAllCommentsByAppUserIdQueryResult
    {
        public int CommentId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public string AppUserId { get; set; }
        public string AppUserName { get; set; }
    }
}
