﻿using MediatR;
using NutriHub.Application.DTOs.SubcategoryDtos;
using NutriHub.Application.Features.Results.CategoryResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Queries.CategoryQueries
{
    public class GetCategoriesMenuQuery : IRequest<IEnumerable<GetCategoriesMenuQueryResult>>
    {

    }
}