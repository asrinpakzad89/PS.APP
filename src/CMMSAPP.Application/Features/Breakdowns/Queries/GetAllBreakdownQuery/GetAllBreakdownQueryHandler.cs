namespace CMMSAPP.Application.Features.Categories.Queries.GetAllBreakdownQuery;

public class GetAllBreakdownQueryHandler : IRequestHandler<GetAllBreakdownQuery, List<BreakdownDto>>
{
    private readonly IEFRepository<Breakdown> _efRepository;
    private readonly IMapper _mapper;

    public GetAllBreakdownQueryHandler(IEFRepository<Breakdown> repository, IMapper mapper)
    {
        _efRepository = repository;
        _mapper = mapper;
    }

    public async Task<List<BreakdownDto>> Handle(GetAllBreakdownQuery query, CancellationToken cancellationToken)
    {
        var Breakdowns = await _efRepository.GetAllAsync(cancellationToken);
        return _mapper.Map<List<BreakdownDto>>(Breakdowns);
    }
}
