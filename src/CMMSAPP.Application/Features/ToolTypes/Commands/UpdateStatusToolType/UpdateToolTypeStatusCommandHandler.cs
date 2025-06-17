namespace CMMSAPP.Application.Features.Tools.Commands.UpdateStatusToolType;

public class UpdateToolTypeStatusCommandHandler : IRequestHandler<UpdateToolTypeStatusCommand, Unit>
{
    private readonly IEFRepository<ToolType> _efRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateToolTypeStatusCommandHandler(IEFRepository<ToolType> repository, IUnitOfWork unitOfWork)
    {
        _efRepository = repository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Unit> Handle(UpdateToolTypeStatusCommand command, CancellationToken cancellationToken)
    {
        var Tool = await _efRepository.GetAsync(command.Id, cancellationToken);

        if (Tool == null)
            throw new NotFoundException("آیتم انتخاب شده معتبر نیست.");

        // Set Tool.ModifiedBy befor send it
        Tool.SetStatus();
        _efRepository.UpdateAsync(Tool);
        await _efRepository.UnitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}