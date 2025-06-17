using CMMSAPP.Domain.AggregatesModel.AssetCategoryAggregate;

namespace CMMSAPP.Application.Features.Categories.Commands.DeleteCategory;

public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, Unit>
{
    private readonly IEFRepository<Category> _repository;

    public DeleteCategoryCommandHandler(IEFRepository<Category> repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteCategoryCommand command, CancellationToken cancellationToken)
    {

        var category = await _repository.GetAsync(command.Id, cancellationToken);
        if (category == null)
            throw new ValidationException("دسته تجهیز با این مشخصات ثبت نشده است.");

        category.Delete();
        _repository.UpdateAsync(category);
        await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
