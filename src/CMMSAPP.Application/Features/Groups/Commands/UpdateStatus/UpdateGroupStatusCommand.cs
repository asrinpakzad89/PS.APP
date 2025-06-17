namespace CMMSAPP.Application.Features.Groups.Commands.UpdateStatus;

public class UpdateGroupStatusCommand : IRequest<Unit>
{
    [JsonIgnore]
    public Guid Id { get; set; }
}
