namespace CMMSAPP.API.Controllers.v1;

public class ToolTypeController : BaseApiControllerWithDefaultRoute
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;
    public ToolTypeController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    //[Authorize(Policy = "admin")]
    [HttpGet("GetAll")]
    public async Task<ApiResult<List<ToolTypeDto>>> GetAll(CancellationToken cancellationToken)
    {
        GetAllToolTypeQuery query = new();
        var result = await _mediator.Send(query, cancellationToken);
        return Ok(result);
    }

    //[Authorize(Policy = "admin")]
    [HttpGet("{id}")]
    public async Task<ApiResult<ToolTypeDto>> GetById(Guid id, CancellationToken cancellationToken)
    {
        var query = new GetToolTypeByIdQuery { Id = id };
        var result = await _mediator.Send(query, cancellationToken);
        return Ok(result);
    }

    //[Authorize(Policy = "admin")]
    [HttpPost("Create")]
    public async Task<ApiResult<ToolTypeIdDto>> Create(CreateToolTypeCommand command, CancellationToken cancellationToken)
    {
        return await _mediator.Send(command, cancellationToken);
    }

    //[Authorize(Policy = "admin")]
    [HttpPatch("{id}/update")]
    public async Task<ApiResult> Update(Guid id, UpdateToolTypeCommand command, CancellationToken cancellationToken)
    {
        command.Id = id;
        await _mediator.Send(command, cancellationToken);
        return Ok();
    }
    //[Authorize(Policy = "admin")]
    [HttpPatch("{id}/status")]
    public async Task<ApiResult> UpdateStatus(Guid id, UpdateToolTypeStatusCommand command, CancellationToken cancellationToken)
    {
        command.Id = id;
        await _mediator.Send(command, cancellationToken);
        return Ok();
    }

    //[Authorize(Policy = "admin")]
    [HttpPatch("{id}/delete")]
    public async Task<ApiResult> Delete(Guid id, DeleteToolTypeCommand command, CancellationToken cancellationToken)
    {
        command.Id = id;
        await _mediator.Send(command, cancellationToken);
        return Ok();
    }


}