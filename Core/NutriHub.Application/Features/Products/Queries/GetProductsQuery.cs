﻿using MediatR;
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
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int OrderBy { get; set; }

        public GetProductsQuery(int pageNumber, int pageSize, int orderBy)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            OrderBy = orderBy;
        }
    }
}
