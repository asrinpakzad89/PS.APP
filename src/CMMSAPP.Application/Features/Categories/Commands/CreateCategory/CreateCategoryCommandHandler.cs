using CMMSAPP.Application.Common.Dtos.Category;
using CMMSAPP.Domain.AggregatesModel.AssetCategoryAggregate;

namespace CMMSAPP.Application.Features.Categories.Commands.CreateCategory;

public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CategoryIdDto>
{
    private readonly IEFRepository<Category> _efRepository;
    private readonly IValidator<CreateCategoryCommand> _validator;
    private CreateCategoryCommand _command;

    public CreateCategoryCommandHandler(IEFRepository<Category> efRepository, IValidator<CreateCategoryCommand> validator)
    {
        _efRepository = efRepository;
        _validator = validator;
    }

    public async Task<CategoryIdDto> Handle(CreateCategoryCommand command, CancellationToken cancellationToken)
    {
        _command = command;

        var validationResult = await _validator.ValidateAsync(command);
        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        Correct();

        var Category = new Category(_command.Title, _command.Code, _command.GroupId);

        await _efRepository.AddAsync(Category, cancellationToken);
        await _efRepository.UnitOfWork.SaveEntitiesAsync();
        return new CategoryIdDto { Id = Category.Id };
    }
    private void Correct()
    {
        _command.Title = _command.Title.HasValue() ? _command.Title.Replace("'", "").Trim() : "";
        _command.Code = _command.Code.HasValue() ? _command.Code.Replace("'", "").Trim() : "";
    }
}