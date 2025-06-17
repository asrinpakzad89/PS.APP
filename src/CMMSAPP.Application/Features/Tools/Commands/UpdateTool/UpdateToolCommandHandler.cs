namespace CMMSAPP.Application.Features.Tools.Commands.UpdateTool;

public class UpdateToolCommandHandler : IRequestHandler<UpdateToolCommand, Unit>
{
    private readonly IEFRepository<Tool> _efRepository;
    private readonly IValidator<UpdateToolCommand> _validator;
    private UpdateToolCommand _command;
    public UpdateToolCommandHandler(IEFRepository<Tool> efRepository, IValidator<UpdateToolCommand> validator)
    {
        _efRepository = efRepository;
        _validator = validator;
    }

    public async Task<Unit> Handle(UpdateToolCommand command, CancellationToken cancellationToken)
    {
        _command = command;

        var validationResult = await _validator.ValidateAsync(command);
        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        Correct();

        var Tool = await _efRepository.GetAsync(_command.Id, cancellationToken);
        if (Tool == null)
            throw new ValidationException("آیتمی با این مشخصات ثبت نشده است.");

        Tool.Update(_command.Title, _command.Code, _command.ToolTypeId, _command.Unit, _command.Specification);
        _efRepository.UpdateAsync(Tool);
        await _efRepository.UnitOfWork.SaveChangesAsync();

        return Unit.Value;
    }
    private void Correct()
    {
        _command.Title = _command.Title.HasValue() ? _command.Title.Replace("'", "").Trim() : "";
        _command.Code = _command.Code.HasValue() ? _command.Code.Replace("'", "").Trim() : "";
        _command.Specification = _command.Specification.HasValue() ? _command.Specification.Replace("'", "").Trim() : "";
    }
}