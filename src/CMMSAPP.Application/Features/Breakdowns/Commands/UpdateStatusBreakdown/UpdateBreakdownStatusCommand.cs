namespace CMMSAPP.Application.Features.Categories.Commands.UpdateStatus;

public class UpdateBreakdownStatusCommand : IRequest<Unit>
{
    [JsonIgnore]
    public Guid Id { get; set; }
}
