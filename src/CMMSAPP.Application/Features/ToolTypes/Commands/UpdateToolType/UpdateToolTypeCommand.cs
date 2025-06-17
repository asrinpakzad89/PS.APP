namespace CMMSAPP.Application.Features.Tools.Commands.UpdateToolType;

public class UpdateToolTypeCommand : IRequest<Unit>
{
    [JsonIgnore]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public ToolGroupEnum Group { get; set; }
}
