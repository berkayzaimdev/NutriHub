using MediatR;
using NutriHub.Application.Features.Results.CategoryResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Queries.CategoryQueries
{
    public class GetCategoryByIdWithProductsAndSubcategoriesQuery : IRequest<GetCategoryByIdWithProductsAndSubcategoriesQueryResult>
    {
        public int Id { get; set; }

        public GetCategoryByIdWithProductsAndSubcategoriesQuery(int id)
        {
            Id = id;
        }
    }
}
