namespace CMMSAPP.Application.Features.Tools.Commands.DeleteTool;

public class DeleteToolCommandHandler : IRequestHandler<DeleteToolCommand, Unit>
{
    private readonly IEFRepository<Tool> _repository;

    public DeleteToolCommandHandler(IEFRepository<Tool> repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteToolCommand command, CancellationToken cancellationToken)
    {

        var Tool = await _repository.GetAsync(command.Id, cancellationToken);
        if (Tool == null)
            throw new ValidationException("آیتمی با این مشخصات ثبت نشده است.");

        Tool.Delete();
        _repository.UpdateAsync(Tool);
        await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
