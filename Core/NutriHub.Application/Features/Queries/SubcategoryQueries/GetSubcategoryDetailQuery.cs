using MediatR;
using NutriHub.Application.Features.Results.SubcategoryResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Queries.SubcategoryQueries
{
    public class GetSubcategoryDetailQuery : IRequest<GetSubcategoryDetailQueryResult>
    {
        public int Id { get; set; }

        public GetSubcategoryDetailQuery(int id)
        {
            Id = id;
        }
    }
}
