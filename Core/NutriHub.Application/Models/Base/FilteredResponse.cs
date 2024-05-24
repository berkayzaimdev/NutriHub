using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Models.Base
{
    public class FilteredResponse<T> : PagedResponse<T> where T : class
    {
        public int OrderBy { get; set; }

        public FilteredResponse(IEnumerable<T> items, int pageNumber, int pageSize, int orderBy) : base(items, pageNumber, pageSize)
        {
            OrderBy = orderBy;
        }
    }
}
