namespace CMMSAPP.Application.Features.Categories.Commands.DeleteVisit;

public class DeleteVisitCommand : IRequest<Unit>
{
    [JsonIgnore]
    public Guid Id { get; set; }
}
