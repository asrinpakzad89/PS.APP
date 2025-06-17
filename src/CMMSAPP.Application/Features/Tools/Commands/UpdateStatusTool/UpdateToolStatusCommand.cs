namespace CMMSAPP.Application.Features.Tools.Commands.UpdateStatusTool;

public class UpdateToolStatusCommand : IRequest<Unit>
{
    [JsonIgnore]
    public Guid Id { get; set; }
}
