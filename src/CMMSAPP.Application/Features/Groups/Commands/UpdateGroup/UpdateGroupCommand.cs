namespace CMMSAPP.Application.Features.Groups.Commands.UpdateGroup;

public class UpdateGroupCommand :IRequest<Unit>
{

    [JsonIgnore]
    public Guid Id { get; set; }
    public string Title { get; set; }
}
