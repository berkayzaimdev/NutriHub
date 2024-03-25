using MediatR;
using NutriHub.Application.Features.Results.CategoryResults;
using NutriHub.Application.Features.Results.SubcategoryResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Queries.SubcategoryQueries
{
    public class GetSubcategoryByIdQuery : IRequest<GetSubcategoryByIdQueryResult>
    {
        public int Id { get; set; }

        public GetSubcategoryByIdQuery(int id)
        {
            Id = id;
        }
    }
}
