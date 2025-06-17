namespace CMMSAPP.Application.Features.Categories.Commands.DeleteVisit;

public class DeleteVisitCommandHandler : IRequestHandler<DeleteVisitCommand, Unit>
{
    private readonly IEFRepository<Visit> _repository;

    public DeleteVisitCommandHandler(IEFRepository<Visit> repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteVisitCommand command, CancellationToken cancellationToken)
    {

        var Visit = await _repository.GetAsync(command.Id, cancellationToken);
        if (Visit == null)
            throw new ValidationException("آیتمی با این مشخصات ثبت نشده است.");

        Visit.Delete();
        _repository.UpdateAsync(Visit);
        await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
