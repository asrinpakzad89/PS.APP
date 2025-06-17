namespace CMMSAPP.Application.Features.ToolTypes.Commands.DeleteToolType;

public class DeleteToolTypeCommand : IRequest<Unit>
{
    [JsonIgnore]
    public Guid Id { get; set; }
}
