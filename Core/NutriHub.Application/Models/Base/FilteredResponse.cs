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

        public FilteredResponse(List<T> items, int pageNumber, int pageSize, int totalCount, int orderBy) : base(items, pageNumber, pageSize, totalCount)
        {
            OrderBy = orderBy;
        }
    }
}
