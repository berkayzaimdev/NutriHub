using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Models.Requests
{
    public class CreateCommentRequest
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        public decimal Rating { get; set; }
    }
}
