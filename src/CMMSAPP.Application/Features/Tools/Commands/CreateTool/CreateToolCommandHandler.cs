namespace CMMSAPP.Application.Features.Tools.Commands.CreateTool;

public class CreateToolCommandHandler : IRequestHandler<CreateToolCommand, ToolIdDto>
{
    private readonly IEFRepository<Tool> _efRepository;
    private readonly IValidator<CreateToolCommand> _validator;
    private CreateToolCommand _command;

    public CreateToolCommandHandler(IEFRepository<Tool> efRepository, IValidator<CreateToolCommand> validator)
    {
        _efRepository = efRepository;
        _validator = validator;
    }

    public async Task<ToolIdDto> Handle(CreateToolCommand command, CancellationToken cancellationToken)
    {
        _command = command;

        var validationResult = await _validator.ValidateAsync(command);
        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        Correct();

        var Tool = new Tool(_command.Title, _command.Code, _command.ToolTypeId , _command.Unit , _command.Specification);

        await _efRepository.AddAsync(Tool, cancellationToken);
        await _efRepository.UnitOfWork.SaveEntitiesAsync();
        return new ToolIdDto { Id = Tool.Id };
    }
    private void Correct()
    {
        _command.Title = _command.Title.HasValue() ? _command.Title.Replace("'", "").Trim() : "";
        _command.Code = _command.Code.HasValue() ? _command.Code.Replace("'", "").Trim() : "";
        _command.Specification = _command.Specification.HasValue() ? _command.Specification.Replace("'", "").Trim() : "";
    }
}