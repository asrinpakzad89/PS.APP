namespace CMMSAPP.API.Controllers.v1;

public partial class AssetController : BaseApiControllerWithDefaultRoute
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;
    public AssetController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

}
