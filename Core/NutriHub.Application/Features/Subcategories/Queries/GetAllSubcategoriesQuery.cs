﻿using MediatR;
using NutriHub.Application.Features.Subcategories.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Subcategories.Queries
{
    public class GetAllSubcategoriesQuery : IRequest<List<GetAllSubcategoriesQueryResult>>
    {
    }
}
