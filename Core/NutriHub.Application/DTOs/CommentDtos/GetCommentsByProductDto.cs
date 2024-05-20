using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.DTOs.CommentDtos
{
    public class GetCommentsByProductDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public decimal Rating { get; set; }
    }
}
