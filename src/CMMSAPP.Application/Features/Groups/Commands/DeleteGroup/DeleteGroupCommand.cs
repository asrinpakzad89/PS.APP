namespace CMMSAPP.Application.Features.Groups.Commands.DeleteGroup;

public class DeleteGroupCommand : IRequest<Unit>
{
    [JsonIgnore]
    public Guid Id { get; set; }
}
