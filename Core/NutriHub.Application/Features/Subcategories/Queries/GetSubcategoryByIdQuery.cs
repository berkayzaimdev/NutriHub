using MediatR;
using NutriHub.Application.Features.Subcategories.Results;

namespace NutriHub.Application.Features.Subcategories.Queries
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
