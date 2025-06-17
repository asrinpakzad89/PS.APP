namespace CMMSAPP.Application.Features.Categories.Commands.UpdateBreakdown;

public class UpdateBreakdownCommand : IRequest<Unit>
{
    [JsonIgnore]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Code { get; set; }
}