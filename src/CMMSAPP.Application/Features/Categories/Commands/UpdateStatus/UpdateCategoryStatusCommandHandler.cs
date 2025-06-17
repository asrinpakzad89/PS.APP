namespace CMMSAPP.Application.Features.Categories.Commands.UpdateStatus;

public class UpdateCategoryStatusCommandHandler : IRequestHandler<UpdateCategoryStatusCommand, Unit>
{
    private readonly IEFRepository<Category> _efRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateCategoryStatusCommandHandler(IEFRepository<Category> CategoryRepository, IUnitOfWork unitOfWork)
    {
        _efRepository = CategoryRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Unit> Handle(UpdateCategoryStatusCommand command, CancellationToken cancellationToken)
    {
        var Category = await _efRepository.GetAsync(command.Id, cancellationToken);

        if (Category == null)
            throw new NotFoundException("آیتم انتخاب شده معتبر نیست.");

        // Set Category.ModifiedBy befor send it
        Category.SetStatus();
        _efRepository.UpdateAsync(Category);
        await _efRepository.UnitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}