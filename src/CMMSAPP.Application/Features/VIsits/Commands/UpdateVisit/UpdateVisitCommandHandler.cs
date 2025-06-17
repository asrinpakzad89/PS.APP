namespace CMMSAPP.Application.Features.Categories.Commands.UpdateVisit;

public class UpdateVisitCommandHandler : IRequestHandler<UpdateVisitCommand, Unit>
{
    private readonly IEFRepository<Visit> _efRepository;
    private readonly IValidator<UpdateVisitCommand> _validator;
    private UpdateVisitCommand _command;
    public UpdateVisitCommandHandler(IEFRepository<Visit> efRepository, IValidator<UpdateVisitCommand> validator)
    {
        _efRepository = efRepository;
        _validator = validator;
    }

    public async Task<Unit> Handle(UpdateVisitCommand command, CancellationToken cancellationToken)
    {
        _command = command;

        var validationResult = await _validator.ValidateAsync(command);
        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        Correct();

        var Visit = await _efRepository.GetAsync(_command.Id, cancellationToken);
        if (Visit == null)
            throw new ValidationException("آیتمی با این مشخصات ثبت نشده است.");

        Visit.Update(_command.Title, _command.Code);
        _efRepository.UpdateAsync(Visit);
        await _efRepository.UnitOfWork.SaveChangesAsync();

        return Unit.Value;
    }
    private void Correct()
    {
        _command.Title = _command.Title.HasValue() ? _command.Title.Replace("'", "").Trim() : "";
        _command.Code = _command.Code.HasValue() ? _command.Code.Replace("'", "").Trim() : "";
    }
}
