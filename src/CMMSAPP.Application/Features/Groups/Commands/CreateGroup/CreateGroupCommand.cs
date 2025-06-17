namespace CMMSAPP.Application.Features.Groups.Commands.CreateGroup;

public class CreateGroupCommand : IRequest<GroupIdDto>
{
    public string Title { get; set; }
}
