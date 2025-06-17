namespace CMMSAPP.Application.Features.Categories.Queries.GetCategoryByIdQuery;

public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, CategoryDto>
{
    private readonly IEFRepository<Category> _repository;
    private readonly IMapper _mapper;
    public GetCategoryByIdQueryHandler(IEFRepository<Category> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<CategoryDto> Handle(GetCategoryByIdQuery query, CancellationToken cancellationToken)
    {
        var Category = await _repository.GetAsync(query.Id, cancellationToken);
        if (Category == null)
            throw new Exception("دسته تجهیزی با این مشخصات ثبت نشده است.");

        return _mapper.Map<CategoryDto>(Category);
    }
}
