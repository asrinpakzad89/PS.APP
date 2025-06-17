namespace CMMSAPP.Application.Features.ToolTypes.Queries.GetToolTypeByIdQuery;

public class GetToolTypeByIdQueryHandler : IRequestHandler<GetToolTypeByIdQuery, ToolTypeDto>
{
    private readonly IEFRepository<ToolType> _repository;
    private readonly IMapper _mapper;
    public GetToolTypeByIdQueryHandler(IEFRepository<ToolType> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ToolTypeDto> Handle(GetToolTypeByIdQuery query, CancellationToken cancellationToken)
    {
        var Tool = await _repository.GetAsync(query.Id, cancellationToken);
        if (Tool == null)
            throw new Exception("آیتمی با این مشخصات ثبت نشده است.");

        return _mapper.Map<ToolTypeDto>(Tool);
    }
}
