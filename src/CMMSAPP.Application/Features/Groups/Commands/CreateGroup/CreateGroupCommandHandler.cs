namespace CMMSAPP.Application.Features.Groups.Commands.CreateGroup;

public class CreateGroupCommandHandler : IRequestHandler<CreateGroupCommand, GroupIdDto>
{
    private readonly IEFRepository<Group> _efRepository;
    private readonly IValidator<CreateGroupCommand> _validator;
    private CreateGroupCommand _command;

    public CreateGroupCommandHandler(IEFRepository<Group> efRepository, IValidator<CreateGroupCommand> validator)
    {
        _efRepository = efRepository;
        _validator = validator;
    }

    public async Task<GroupIdDto> Handle(CreateGroupCommand command, CancellationToken cancellationToken)
    {
        _command = command;

        var validationResult = await _validator.ValidateAsync(command);
        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        Correct();
        var group = new Group(_command.Title);

        await _efRepository.AddAsync(group, cancellationToken);
        await _efRepository.UnitOfWork.SaveEntitiesAsync();
        return new GroupIdDto { Id = group.Id };
    }

    private void Correct()
    {
        _command.Title = _command.Title.HasValue() ? _command.Title.Replace("'", "").Trim() : "";
    }

}