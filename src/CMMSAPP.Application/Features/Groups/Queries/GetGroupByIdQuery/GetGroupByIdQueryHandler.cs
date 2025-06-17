namespace CMMSAPP.Application.Features.Groups.Queries.GetGroupByIdQuery;

public class GetGroupByIdQueryHandler : IRequestHandler<GetGroupByIdQuery, GroupDto>
{
    private readonly IEFRepository<Group> _repository;
    private readonly IMapper _mapper;
    public GetGroupByIdQueryHandler(IEFRepository<Group> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<GroupDto> Handle(GetGroupByIdQuery query, CancellationToken cancellationToken)
    {
        var group = await _repository.GetAsync(query.Id, cancellationToken);
        if (group == null)
            throw new Exception("گروهی با این مشخصات ثبت نشده است.");

        return _mapper.Map<GroupDto>(group);
    }
}
