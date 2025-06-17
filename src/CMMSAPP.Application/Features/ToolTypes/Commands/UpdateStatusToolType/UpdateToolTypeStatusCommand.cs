namespace CMMSAPP.Application.Features.Tools.Commands.UpdateStatusToolType;

public class UpdateToolTypeStatusCommand : IRequest<Unit>
{
    [JsonIgnore]
    public Guid Id { get; set; }
}
