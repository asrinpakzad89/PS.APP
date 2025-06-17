namespace CMMSAPP.Application.Features.Visits.Commands.CreateVisit;

public class CreateVisitCommand : IRequest<VisitIdDto>
{
    public string Title { get; set; }
    public string Code { get; set; }
}
