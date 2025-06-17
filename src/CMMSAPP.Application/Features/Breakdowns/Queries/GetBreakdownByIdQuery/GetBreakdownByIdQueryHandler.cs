namespace CMMSAPP.Application.Features.Categories.Queries.GetBreakdownByIdQuery;

public class GetBreakdownByIdQueryHandler : IRequestHandler<GetBreakdownByIdQuery, BreakdownDto>
{
    private readonly IEFRepository<Breakdown> _repository;
    private readonly IMapper _mapper;
    public GetBreakdownByIdQueryHandler(IEFRepository<Breakdown> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<BreakdownDto> Handle(GetBreakdownByIdQuery query, CancellationToken cancellationToken)
    {
        var Breakdown = await _repository.GetAsync(query.Id, cancellationToken);
        if (Breakdown == null)
            throw new Exception("دسته تجهیزی با این مشخصات ثبت نشده است.");

        return _mapper.Map<BreakdownDto>(Breakdown);
    }
}
