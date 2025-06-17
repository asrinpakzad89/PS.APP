namespace CMMSAPP.Application.Features.Categories.Commands.DeleteBreakdown;

public class DeleteBreakdownCommandHandler : IRequestHandler<DeleteBreakdownCommand, Unit>
{
    private readonly IEFRepository<Breakdown> _repository;

    public DeleteBreakdownCommandHandler(IEFRepository<Breakdown> repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteBreakdownCommand command, CancellationToken cancellationToken)
    {

        var Breakdown = await _repository.GetAsync(command.Id, cancellationToken);
        if (Breakdown == null)
            throw new ValidationException("آیتمی با این مشخصات ثبت نشده است.");

        Breakdown.Delete();
        _repository.UpdateAsync(Breakdown);
        await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
