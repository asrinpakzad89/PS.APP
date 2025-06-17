namespace CMMSAPP.Application.Features.Categories.Commands.CreateVisit;

public class CreateVisitCommandHandler : IRequestHandler<CreateVisitCommand, VisitIdDto>
{
    private readonly IEFRepository<Visit> _efRepository;
    private readonly IValidator<CreateVisitCommand> _validator;
    private CreateVisitCommand _command;

    public CreateVisitCommandHandler(IEFRepository<Visit> efRepository, IValidator<CreateVisitCommand> validator)
    {
        _efRepository = efRepository;
        _validator = validator;
    }

    public async Task<VisitIdDto> Handle(CreateVisitCommand command, CancellationToken cancellationToken)
    {
        _command = command;

        var validationResult = await _validator.ValidateAsync(command);
        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        Correct();

        var Visit = new Visit(_command.Title, _command.Code);

        await _efRepository.AddAsync(Visit, cancellationToken);
        await _efRepository.UnitOfWork.SaveEntitiesAsync();
        return new VisitIdDto { Id = Visit.Id };
    }
    private void Correct()
    {
        _command.Title = _command.Title.HasValue() ? _command.Title.Replace("'", "").Trim() : "";
        _command.Code = _command.Code.HasValue() ? _command.Code.Replace("'", "").Trim() : "";
    }
}