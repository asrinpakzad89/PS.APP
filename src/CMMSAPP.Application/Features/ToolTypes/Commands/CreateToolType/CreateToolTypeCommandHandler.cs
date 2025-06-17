namespace CMMSAPP.Application.Features.ToolTypes.Commands.CreateToolType;

public class CreateToolTypeCommandHandler: IRequestHandler<CreateToolTypeCommand, ToolTypeIdDto>
{
    private readonly IEFRepository<ToolType> _efRepository;
    private readonly IValidator<CreateToolTypeCommand> _validator;
    private CreateToolTypeCommand _command;

    public CreateToolTypeCommandHandler(IEFRepository<ToolType> efRepository, IValidator<CreateToolTypeCommand> validator)
    {
        _efRepository = efRepository;
        _validator = validator;
    }

    public async Task<ToolTypeIdDto> Handle(CreateToolTypeCommand command, CancellationToken cancellationToken)
    {
        _command = command;

        var validationResult = await _validator.ValidateAsync(command);
        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        Correct();

        var Tool = new ToolType(_command.Title, _command.Group);

        await _efRepository.AddAsync(Tool, cancellationToken);
        await _efRepository.UnitOfWork.SaveEntitiesAsync();
        return new ToolTypeIdDto { Id = Tool.Id };
    }
    private void Correct()
    {
        _command.Title = _command.Title.HasValue() ? _command.Title.Replace("'", "").Trim() : "";
    }
}