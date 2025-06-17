namespace CMMSAPP.Application.Features.ToolTypes.Queries.GetAllToolTypeQuery;

public class GetAllToolTypeQueryHandler : IRequestHandler<GetAllToolTypeQuery, List<ToolTypeDto>>
{
    private readonly IEFRepository<ToolType> _efRepository;
    private readonly IMapper _mapper;

    public GetAllToolTypeQueryHandler(IEFRepository<ToolType> repository, IMapper mapper)
    {
        _efRepository = repository;
        _mapper = mapper;
    }

    public async Task<List<ToolTypeDto>> Handle(GetAllToolTypeQuery query, CancellationToken cancellationToken)
    {
        var Tools = await _efRepository.GetAllAsync(cancellationToken);
        return _mapper.Map<List<ToolTypeDto>>(Tools);
    }
}
