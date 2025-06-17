using CMMSAPP.Application.Features.Groups.Commands.UpdateStatus;

namespace CMMSAPP.API.Controllers.v1;

public class GroupController : BaseApiControllerWithDefaultRoute
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;
    public GroupController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    //[Authorize(Policy = "admin")]
    [HttpGet("GetAll")]
    public async Task<ApiResult<List<GroupDto>>> GetAll(CancellationToken cancellationToken)
    {
        GetAllGroupQuery query = new();
        var result = await _mediator.Send(query, cancellationToken);
        return Ok(result);
    }

    //[Authorize(Policy = "admin")]
    [HttpGet("{id}")]
    public async Task<ApiResult<GroupDto>> GetById(Guid id, CancellationToken cancellationToken)
    {
        var query = new GetGroupByIdQuery { Id = id };
        var result = await _mediator.Send(query, cancellationToken);
        return Ok(result);
    }

    //[Authorize(Policy = "admin")]
    [HttpPost("create")]
    public async Task<ApiResult<GroupIdDto>> Create(CreateGroupCommand command, CancellationToken cancellationToken)
    {
        return await _mediator.Send(command, cancellationToken);
    }

    //[Authorize(Policy = "admin")]
    [HttpPatch("{id}/update")]
    public async Task<ApiResult> Update(Guid id, UpdateGroupCommand command, CancellationToken cancellationToken)
    {
        command.Id = id;
        await _mediator.Send(command, cancellationToken);
        return Ok();
    }

    //[Authorize(Policy = "admin")]
    [HttpPatch("{id}/status")]
    public async Task<ApiResult> UpdateStatus(Guid id, UpdateGroupStatusCommand command, CancellationToken cancellationToken)
    {
        command.Id = id;
        await _mediator.Send(command, cancellationToken);
        return Ok();
    }

    //[Authorize(Policy = "admin")]
    [HttpPatch("{id}/delete")]
    public async Task<ApiResult> Delete(Guid id, DeleteGroupCommand command, CancellationToken cancellationToken)
    {
        command.Id = id;
        await _mediator.Send(command, cancellationToken);
        return Ok();
    }   
}
