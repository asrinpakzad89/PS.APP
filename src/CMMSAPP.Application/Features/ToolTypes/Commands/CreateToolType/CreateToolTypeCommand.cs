namespace CMMSAPP.Application.Features.ToolTypes.Commands.CreateToolType;

public class CreateToolTypeCommand : IRequest<ToolTypeIdDto>
{
    public string Title { get; set; }
    public ToolGroupEnum Group { get; set; }
}
