using CMMSAPP.Application.Features.Tools.Commands.UpdateToolType;

namespace CMMSAPP.Application.Features.ToolTypes.Commands.UpdateToolType;

public class UpdateToolTypeCommandHandler : IRequestHandler<UpdateToolTypeCommand, Unit>
{
    private readonly IEFRepository<ToolType> _efRepository;
    private readonly IValidator<UpdateToolTypeCommand> _validator;
    private UpdateToolTypeCommand _command;
    public UpdateToolTypeCommandHandler(IEFRepository<ToolType> efRepository, IValidator<UpdateToolTypeCommand> validator)
    {
        _efRepository = efRepository;
        _validator = validator;
    }

    public async Task<Unit> Handle(UpdateToolTypeCommand command, CancellationToken cancellationToken)
    {
        _command = command;

        var validationResult = await _validator.ValidateAsync(command);
        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        Correct();

        var ToolType = await _efRepository.GetAsync(_command.Id, cancellationToken);
        if (ToolType == null)
            throw new ValidationException("آیتمی با این مشخصات ثبت نشده است.");

        ToolType.Update(_command.Title, _command.Group);
        _efRepository.UpdateAsync(ToolType);
        await _efRepository.UnitOfWork.SaveChangesAsync();

        return Unit.Value;
    }
    private void Correct()
    {
        _command.Title = _command.Title.HasValue() ? _command.Title.Replace("'", "").Trim() : "";
    }
}