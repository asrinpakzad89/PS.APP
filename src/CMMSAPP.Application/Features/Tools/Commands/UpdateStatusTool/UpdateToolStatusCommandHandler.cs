namespace CMMSAPP.Application.Features.Tools.Commands.UpdateStatusTool;

public class UpdateToolStatusCommandHandler : IRequestHandler<UpdateToolStatusCommand, Unit>
{
    private readonly IEFRepository<Tool> _efRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateToolStatusCommandHandler(IEFRepository<Tool> ToolRepository, IUnitOfWork unitOfWork)
    {
        _efRepository = ToolRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Unit> Handle(UpdateToolStatusCommand command, CancellationToken cancellationToken)
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