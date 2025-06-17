using CMMSAPP.Application.Common.Dtos.Visit;

namespace CMMSAPP.Application.Features.Categories.Queries.GetVisitByIdQuery;

public class GetVisitByIdQuery : IRequest<VisitDto>
{
    public Guid Id { get; set; }
}