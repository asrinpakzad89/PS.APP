namespace CMMSAPP.Application.Features.Categories.Commands.UpdateStatus;

public class UpdateBreakdownStatusCommandHandler : IRequestHandler<UpdateBreakdownStatusCommand, Unit>
{
    private readonly IEFRepository<Breakdown> _efRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateBreakdownStatusCommandHandler(IEFRepository<Breakdown> BreakdownRepository, IUnitOfWork unitOfWork)
    {
        _efRepository = BreakdownRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Unit> Handle(UpdateBreakdownStatusCommand command, CancellationToken cancellationToken)
    {
        var Breakdown = await _efRepository.GetAsync(command.Id, cancellationToken);

        if (Breakdown == null)
            throw new NotFoundException("آیتم انتخاب شده معتبر نیست.");

        // Set Breakdown.ModifiedBy befor send it
        Breakdown.SetStatus();
        _efRepository.UpdateAsync(Breakdown);
        await _efRepository.UnitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}