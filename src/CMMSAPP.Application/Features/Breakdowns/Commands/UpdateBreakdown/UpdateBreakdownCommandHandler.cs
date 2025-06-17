namespace CMMSAPP.Application.Features.Categories.Commands.UpdateBreakdown;

public class UpdateBreakdownCommandHandler : IRequestHandler<UpdateBreakdownCommand, Unit>
{
    private readonly IEFRepository<Breakdown> _efRepository;
    private readonly IValidator<UpdateBreakdownCommand> _validator;
    private UpdateBreakdownCommand _command;
    public UpdateBreakdownCommandHandler(IEFRepository<Breakdown> efRepository, IValidator<UpdateBreakdownCommand> validator)
    {
        _efRepository = efRepository;
        _validator = validator;
    }

    public async Task<Unit> Handle(UpdateBreakdownCommand command, CancellationToken cancellationToken)
    {
        _command = command;

        var validationResult = await _validator.ValidateAsync(command);
        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        Correct();

        var Breakdown = await _efRepository.GetAsync(_command.Id, cancellationToken);
        if (Breakdown == null)
            throw new ValidationException("آیتمی با این مشخصات ثبت نشده است.");

        Breakdown.Update(_command.Title, _command.Code);
        _efRepository.UpdateAsync(Breakdown);
        await _efRepository.UnitOfWork.SaveChangesAsync();

        return Unit.Value;
    }
    private void Correct()
    {
        _command.Title = _command.Title.HasValue() ? _command.Title.Replace("'", "").Trim() : "";
        _command.Code = _command.Code.HasValue() ? _command.Code.Replace("'", "").Trim() : "";
    }
}
