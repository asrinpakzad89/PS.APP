namespace CMMSAPP.Application.Features.Groups.Queries.GetAllGroupQuery;

public class GetAllGroupQueryHandler : IRequestHandler<GetAllGroupQuery, List<GroupDto>>
{
    private readonly IEFRepository<Group> _efRepository;
    private readonly IMapper _mapper;

    public GetAllGroupQueryHandler(IEFRepository<Group> repository, IMapper mapper)
    {
        _efRepository = repository;
        _mapper = mapper;
    }

    public async Task<List<GroupDto>> Handle(GetAllGroupQuery query, CancellationToken cancellationToken)
    {
        var Groups = await _efRepository.GetAllAsync(cancellationToken);
        return _mapper.Map<List<GroupDto>>(Groups);
    }
}
