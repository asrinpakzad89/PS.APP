namespace CMMSAPP.Application.Features.Categories.Queries.GetAllCategoryQuery;

public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQuery, List<CategoryDto>>
{
    private readonly IEFRepository<Category> _efRepository;
    private readonly IMapper _mapper;

    public GetAllCategoryQueryHandler(IEFRepository<Category> repository, IMapper mapper)
    {
        _efRepository = repository;
        _mapper = mapper;
    }

    public async Task<List<CategoryDto>> Handle(GetAllCategoryQuery query, CancellationToken cancellationToken)
    {
        var Categorys = await _efRepository.GetAllAsync(cancellationToken);
        return _mapper.Map<List<CategoryDto>>(Categorys);
    }
}
