namespace CMMSAPP.Application.Features.Categories.Commands.UpdateVisit;

public class UpdateVisitCommand : IRequest<Unit>
{
    [JsonIgnore]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Code { get; set; }
}