namespace CMMSAPP.Application.Features.Groups.Commands.UpdateStatus;

public class UpdateGroupStatusCommandHandler : IRequestHandler<UpdateGroupStatusCommand, Unit>
{
    private readonly IEFRepository<Group> _efRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateGroupStatusCommandHandler(IEFRepository<Group> groupRepository, IUnitOfWork unitOfWork)
    {
        _efRepository = groupRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Unit> Handle(UpdateGroupStatusCommand command, CancellationToken cancellationToken)
    {
        var group = await _efRepository.GetAsync(command.Id, cancellationToken);

        if (group == null)
            throw new NotFoundException("گروه تجهیز معتبر نیست.");

        // Set group.ModifiedBy befor send it
        group.SetStatus();
        _efRepository.UpdateAsync(group);
        await _efRepository.UnitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}