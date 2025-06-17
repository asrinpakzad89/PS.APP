namespace CMMSAPP.Application.Features.Categories.Queries.GetBreakdownByIdQuery;

public class GetBreakdownByIdQuery : IRequest<BreakdownDto>
{
    public Guid Id { get; set; }
}