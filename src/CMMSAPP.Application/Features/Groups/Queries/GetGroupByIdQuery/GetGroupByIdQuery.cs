namespace CMMSAPP.Application.Features.Groups.Queries.GetGroupByIdQuery;

public class GetGroupByIdQuery : IRequest<GroupDto>
{
    public Guid Id { get; set; }
}
