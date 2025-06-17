namespace CMMSAPP.Application.Features.Categories.Commands.UpdateCategory;

public class UpdateCategoryCommand : IRequest<Unit>
{
    [JsonIgnore]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Code { get; set; }
    public Guid GroupId { get; set; }

}