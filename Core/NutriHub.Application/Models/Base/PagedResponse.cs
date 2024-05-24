using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Models.Base
{
    public class PagedResponse<T> where T : class
    {
        public List<T> Items { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);

        public PagedResponse(IEnumerable<T> items, int pageNumber, int pageSize)
        {
            TotalCount = items.Count();
            Items = items.Skip(pageSize*(pageNumber-1)).Take(pageSize).ToList();
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}
