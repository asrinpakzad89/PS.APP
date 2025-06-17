namespace CMMSAPP.Application.Features.Categories.Commands.CreateCategory;

public class CreateCategoryCommand : IRequest<CategoryIdDto>
{
    public string Title { get; set; }
    public string Code { get; set; }
    public Guid GroupId { get; set; }

}
