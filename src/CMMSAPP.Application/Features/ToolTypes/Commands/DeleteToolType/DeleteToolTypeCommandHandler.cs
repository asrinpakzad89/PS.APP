using CMMSAPP.Application.Features.Tools.Commands.DeleteTool;

namespace CMMSAPP.Application.Features.ToolTypes.Commands.DeleteToolType;

public class DeleteToolTypeCommandHandler : IRequestHandler<DeleteToolTypeCommand, Unit>
{
    private readonly IEFRepository<ToolType> _repository;

    public DeleteToolTypeCommandHandler(IEFRepository<ToolType> repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteToolTypeCommand command, CancellationToken cancellationToken)
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
