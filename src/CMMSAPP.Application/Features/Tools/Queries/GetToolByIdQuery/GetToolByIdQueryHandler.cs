namespace CMMSAPP.Application.Features.Tools.Queries.GetToolByIdQuery;

public class GetToolByIdQueryHandler : IRequestHandler<GetToolByIdQuery, ToolDto>
{
    private readonly IEFRepository<Tool> _repository;
    private readonly IMapper _mapper;
    public GetToolByIdQueryHandler(IEFRepository<Tool> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ToolDto> Handle(GetToolByIdQuery query, CancellationToken cancellationToken)
    {
        var Tool = await _repository.GetAsync(query.Id, cancellationToken);
        if (Tool == null)
            throw new Exception("آیتمی با این مشخصات ثبت نشده است.");

        return _mapper.Map<ToolDto>(Tool);
    }
}
