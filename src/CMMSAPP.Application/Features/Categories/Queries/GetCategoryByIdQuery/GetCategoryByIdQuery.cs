namespace CMMSAPP.Application.Features.Categories.Queries.GetCategoryByIdQuery;

public class GetCategoryByIdQuery : IRequest<CategoryDto>
{
    public Guid Id { get; set; }
}