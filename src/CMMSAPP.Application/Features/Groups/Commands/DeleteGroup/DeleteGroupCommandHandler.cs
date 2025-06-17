using CMMSAPP.Domain.AggregatesModel.AssetCategoryAggregate;

namespace CMMSAPP.Application.Features.Groups.Commands.DeleteGroup;

public class DeleteGroupCommandHandler : IRequestHandler<DeleteGroupCommand, Unit>
{
    private readonly IEFRepository<Group> _repository;

    public DeleteGroupCommandHandler(IEFRepository<Group> repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteGroupCommand command, CancellationToken cancellationToken)
    {

        var group = await _repository.GetAsync(command.Id, cancellationToken);
        if (group == null)
            throw new ValidationException("گروهی با این مشخصات ثبت نشده است.");

        group.Delete();
        _repository.UpdateAsync(group);
        await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
