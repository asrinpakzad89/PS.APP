namespace CMMSAPP.Application.Features.Categories.Commands.DeleteBreakdown;

public class DeleteBreakdownCommand : IRequest<Unit>
{
    [JsonIgnore]
    public Guid Id { get; set; }
}
