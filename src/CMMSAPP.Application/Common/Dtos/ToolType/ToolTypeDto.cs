namespace CMMSAPP.Application.Common.Dtos.Tool;

public class ToolTypeDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public ToolGroupEnum Type { get; set; }
}
