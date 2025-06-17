namespace CMMSAPP.Application.Features.Categories.Commands.DeleteCategory;

public class DeleteCategoryCommand : IRequest<Unit>
{
    [JsonIgnore]
    public Guid Id { get; set; }
}
