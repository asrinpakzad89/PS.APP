namespace CMMSAPP.Application.Features.Categories.Commands.CreateBreakdown;

public class CreateBreakdownCommandHandler : IRequestHandler<CreateBreakdownCommand, BreakdownIdDto>
{
    private readonly IEFRepository<Breakdown> _efRepository;
    private readonly IValidator<CreateBreakdownCommand> _validator;
    private CreateBreakdownCommand _command;

    public CreateBreakdownCommandHandler(IEFRepository<Breakdown> efRepository, IValidator<CreateBreakdownCommand> validator)
    {
        _efRepository = efRepository;
        _validator = validator;
    }

    public async Task<BreakdownIdDto> Handle(CreateBreakdownCommand command, CancellationToken cancellationToken)
    {
        _command = command;

        var validationResult = await _validator.ValidateAsync(command);
        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        Correct();

        var Breakdown = new Breakdown(_command.Title, _command.Code);

        await _efRepository.AddAsync(Breakdown, cancellationToken);
        await _efRepository.UnitOfWork.SaveEntitiesAsync();
        return new BreakdownIdDto { Id = Breakdown.Id };
    }
    private void Correct()
    {
        _command.Title = _command.Title.HasValue() ? _command.Title.Replace("'", "").Trim() : "";
        _command.Code = _command.Code.HasValue() ? _command.Code.Replace("'", "").Trim() : "";
    }
}