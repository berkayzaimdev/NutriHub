﻿using MediatR;
using NutriHub.Application.Features.CQRS.Results.ProductResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.CQRS.Queries.ProductQueries
{
    public class GetProductsQuery : IRequest<List<GetProductsQueryResult>>
    {
    }
}
