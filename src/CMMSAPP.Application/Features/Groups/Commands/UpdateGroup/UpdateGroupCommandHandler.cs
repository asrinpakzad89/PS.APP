namespace CMMSAPP.Application.Features.Groups.Commands.UpdateGroup;

public class UpdateGroupCommandHandler : IRequestHandler<UpdateGroupCommand, Unit>
{
    private readonly IEFRepository<Group> _efRepository;
    private readonly IValidator<UpdateGroupCommand> _validator;
    private UpdateGroupCommand _command;
    public UpdateGroupCommandHandler(IEFRepository<Group> efRepository, IValidator<UpdateGroupCommand> validator)
    {
        _efRepository = efRepository;
        _validator = validator;
    }

    public async Task<Unit> Handle(UpdateGroupCommand command, CancellationToken cancellationToken)
    {
        _command = command;

        var validationResult = await _validator.ValidateAsync(command);
        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        Correct();

        var group = await _efRepository.GetAsync(_command.Id, cancellationToken);
        if (group == null)
            throw new ValidationException("گروهی با این مشخصات ثبت نشده است.");

        group.Update(_command.Title);
        _efRepository.UpdateAsync(group);
        await _efRepository.UnitOfWork.SaveChangesAsync();

        return Unit.Value;
    }
    private void Correct()
    {
        _command.Title = _command.Title.HasValue() ? _command.Title.Replace("'", "").Trim() : "";
    }
}