namespace CMMSAPP.Application.Common.Dtos.Tool;

public class ToolDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Code { get; set; }
    public Guid ToolTypeId { get; private set; }
    public UnitOfMeasureEnum Unit { get; set; }
    public string? Specification { get; set; }
}
