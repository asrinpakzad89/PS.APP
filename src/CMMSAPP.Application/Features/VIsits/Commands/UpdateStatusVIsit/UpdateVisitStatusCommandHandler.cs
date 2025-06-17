namespace CMMSAPP.Application.Features.Categories.Commands.UpdateStatus;

public class UpdateVisitStatusCommandHandler : IRequestHandler<UpdateVisitStatusCommand, Unit>
{
    private readonly IEFRepository<Visit> _efRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateVisitStatusCommandHandler(IEFRepository<Visit> VisitRepository, IUnitOfWork unitOfWork)
    {
        _efRepository = VisitRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Unit> Handle(UpdateVisitStatusCommand command, CancellationToken cancellationToken)
    {
        var Visit = await _efRepository.GetAsync(command.Id, cancellationToken);

        if (Visit == null)
            throw new NotFoundException("آیتم انتخاب شده معتبر نیست.");

        // Set Visit.ModifiedBy befor send it
        Visit.SetStatus();
        _efRepository.UpdateAsync(Visit);
        await _efRepository.UnitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}