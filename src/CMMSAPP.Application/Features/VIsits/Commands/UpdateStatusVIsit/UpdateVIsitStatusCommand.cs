namespace CMMSAPP.Application.Features.Categories.Commands.UpdateStatus;

public class UpdateVisitStatusCommand : IRequest<Unit>
{
    [JsonIgnore]
    public Guid Id { get; set; }
}
