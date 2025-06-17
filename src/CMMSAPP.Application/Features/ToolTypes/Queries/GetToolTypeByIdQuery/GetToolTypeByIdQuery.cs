namespace CMMSAPP.Application.Features.ToolTypes.Queries.GetToolTypeByIdQuery;

public class GetToolTypeByIdQuery : IRequest<ToolTypeDto>
{
    public Guid Id { get; set; }
}