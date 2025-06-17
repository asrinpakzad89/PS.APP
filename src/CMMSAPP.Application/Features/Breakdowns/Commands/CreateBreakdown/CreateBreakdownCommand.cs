namespace CMMSAPP.Application.Features.Breakdowns.Commands.CreateBreakdown;

public class CreateBreakdownCommand : IRequest<BreakdownIdDto>
{
    public string Title { get; set; }
    public string Code { get; set; }
}
