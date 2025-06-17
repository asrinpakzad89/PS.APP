namespace CMMSAPP.Application.Features.Tools.Queries.GetToolByIdQuery;

public class GetToolByIdQuery : IRequest<ToolDto>
{
    public Guid Id { get; set; }
}