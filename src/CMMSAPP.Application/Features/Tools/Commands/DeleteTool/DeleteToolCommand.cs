namespace CMMSAPP.Application.Features.Tools.Commands.DeleteTool;

public class DeleteToolCommand : IRequest<Unit>
{
    [JsonIgnore]
    public Guid Id { get; set; }
}