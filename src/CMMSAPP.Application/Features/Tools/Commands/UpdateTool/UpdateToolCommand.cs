namespace CMMSAPP.Application.Features.Tools.Commands.UpdateTool;

public class UpdateToolCommand : IRequest<Unit>
{
    [JsonIgnore]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Code { get; set; }
    public Guid ToolTypeId { get; set; }
    public UnitOfMeasureEnum Unit { get; set; }
    public string? Specification { get; set; }
}
