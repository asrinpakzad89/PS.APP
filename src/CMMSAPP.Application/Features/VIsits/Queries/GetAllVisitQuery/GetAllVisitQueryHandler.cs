using CMMSAPP.Application.Common.Dtos.Visit;
using CMMSAPP.Domain.AggregatesModel.VisitAggregate;

namespace CMMSAPP.Application.Features.Categories.Queries.GetAllVisitQuery;

public class GetAllVisitQueryHandler : IRequestHandler<GetAllVisitQuery, List<VisitDto>>
{
    private readonly IEFRepository<Visit> _efRepository;
    private readonly IMapper _mapper;

    public GetAllVisitQueryHandler(IEFRepository<Visit> repository, IMapper mapper)
    {
        _efRepository = repository;
        _mapper = mapper;
    }

    public async Task<List<VisitDto>> Handle(GetAllVisitQuery query, CancellationToken cancellationToken)
    {
        var Visits = await _efRepository.GetAllAsync(cancellationToken);
        return _mapper.Map<List<VisitDto>>(Visits);
    }
}
