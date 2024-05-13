using MediatR;
using NutriHub.Application.Features.Categories.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Categories.Queries
{
    public class GetCategoryDetailQuery : IRequest<GetCategoryDetailQueryResult>
    {
        public int Id { get; set; }

        public GetCategoryDetailQuery(int id)
        {
            Id = id;
        }
    }
}
