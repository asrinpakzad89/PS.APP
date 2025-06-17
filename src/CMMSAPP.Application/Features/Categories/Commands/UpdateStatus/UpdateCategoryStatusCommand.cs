namespace CMMSAPP.Application.Features.Categories.Commands.UpdateStatus;

public class UpdateCategoryStatusCommand : IRequest<Unit>
{
    [JsonIgnore]
    public Guid Id { get; set; }
}
