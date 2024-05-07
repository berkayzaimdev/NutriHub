﻿using MediatR;
using NutriHub.Application.Features.Results.CategoryResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Queries.SubcategoryQueries
{
    public class GetSubcategoriesMenuQuery : IRequest<List<GetCategoriesMenuQueryResult>>
    {
    }
}