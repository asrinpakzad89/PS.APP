using CMMSAPP.Application.Common.Dtos.Visit;
using CMMSAPP.Domain.AggregatesModel.VisitAggregate;

namespace CMMSAPP.Application.Features.Categories.Queries.GetVisitByIdQuery;

public class GetVisitByIdQueryHandler : IRequestHandler<GetVisitByIdQuery, VisitDto>
{
    private readonly IEFRepository<Visit> _repository;
    private readonly IMapper _mapper;
    public GetVisitByIdQueryHandler(IEFRepository<Visit> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<VisitDto> Handle(GetVisitByIdQuery query, CancellationToken cancellationToken)
    {
        var Visit = await _repository.GetAsync(query.Id, cancellationToken);
        if (Visit == null)
            throw new Exception("دسته تجهیزی با این مشخصات ثبت نشده است.");

        return _mapper.Map<VisitDto>(Visit);
    }
}
