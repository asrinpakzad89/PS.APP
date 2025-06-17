namespace CMMSAPP.Application.Features.Tools.Commands.CreateTool;

public class CreateToolCommand : IRequest<ToolIdDto>
{
    public string Title { get; set; }
    public string Code { get; set; }
    public Guid ToolTypeId { get; set; }
    public UnitOfMeasureEnum Unit { get; set; }
    public string? Specification { get; set; }
}
