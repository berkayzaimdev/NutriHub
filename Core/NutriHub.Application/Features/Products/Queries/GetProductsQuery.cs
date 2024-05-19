using MediatR;
using NutriHub.Application.Features.Products.Results;
using NutriHub.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Products.Queries
{
    public class GetProductsQuery : IRequest<PagedResponse<GetProductsQueryResult>>
    {
        public int PageNumber { get; set; } = 0;
        public int PageSize { get; set; } = 0;
        public int OrderBy { get; set; } = 0;

        public GetProductsQuery(int pageNumber, int pageSize, int orderBy)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            OrderBy = orderBy;
        }
    }
}
