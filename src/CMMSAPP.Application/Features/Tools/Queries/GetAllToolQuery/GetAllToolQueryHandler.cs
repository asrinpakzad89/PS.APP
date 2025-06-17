namespace CMMSAPP.Application.Features.Tools.Queries.GetAllToolQuery;

public class GetAllToolQueryHandler : IRequestHandler<GetAllToolQuery, List<ToolDto>>
{
    private readonly IEFRepository<Tool> _efRepository;
    private readonly IMapper _mapper;

    public GetAllToolQueryHandler(IEFRepository<Tool> repository, IMapper mapper)
    {
        _efRepository = repository;
        _mapper = mapper;
    }

    public async Task<List<ToolDto>> Handle(GetAllToolQuery query, CancellationToken cancellationToken)
    {
        var Tools = await _efRepository.GetAllAsync(cancellationToken);
        return _mapper.Map<List<ToolDto>>(Tools);
    }
}
