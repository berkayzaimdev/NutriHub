using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Comments.Results
{
    public class GetCommentsByUserIdQueryResult
    {
        public int CommentId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
    }
}
