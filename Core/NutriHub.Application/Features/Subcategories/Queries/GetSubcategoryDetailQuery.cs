using MediatR;
using NutriHub.Application.Features.Subcategories.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Subcategories.Queries
{
    public class GetSubcategoryDetailQuery : IRequest<GetSubcategoryDetailQueryResult>
    {
        public int Id { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int OrderBy { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }

        public GetSubcategoryDetailQuery(int id, int pageNumber, int pageSize, int orderBy, int minPrice, int maxPrice)
        {
            Id = id;
            PageNumber = pageNumber;
            PageSize = pageSize;
            OrderBy = orderBy;
            MinPrice = minPrice;
            MaxPrice = maxPrice;
        }
    }
}
