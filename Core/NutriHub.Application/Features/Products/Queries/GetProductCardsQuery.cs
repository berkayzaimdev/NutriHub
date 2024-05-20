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
    public class GetProductCardsQuery : IRequest<PagedResponse<GetProductCardsQueryResult>>
    {
        public string UserId { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public GetProductCardsQuery(string userId, int pageNumber, int pageSize)
        {
            UserId = userId;
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}
