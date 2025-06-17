namespace CMMSAPP.Application.Features.Categories.Commands.UpdateCategory;

public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, Unit>
{
    private readonly IEFRepository<Category> _efRepository;
    private readonly IValidator<UpdateCategoryCommand> _validator;
    private UpdateCategoryCommand _command;
    public UpdateCategoryCommandHandler(IEFRepository<Category> efRepository, IValidator<UpdateCategoryCommand> validator)
    {
        _efRepository = efRepository;
        _validator = validator;
    }

    public async Task<Unit> Handle(UpdateCategoryCommand command, CancellationToken cancellationToken)
    {
        _command = command;

        var validationResult = await _validator.ValidateAsync(command);
        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        Correct();

        var Category = await _efRepository.GetAsync(_command.Id, cancellationToken);
        if (Category == null)
            throw new ValidationException("دسته تجهیزی با این مشخصات ثبت نشده است.");

        Category.Update(_command.Title, _command.Code, _command.GroupId);
        _efRepository.UpdateAsync(Category);
        await _efRepository.UnitOfWork.SaveChangesAsync();

        return Unit.Value;
    }
    private void Correct()
    {
        _command.Title = _command.Title.HasValue() ? _command.Title.Replace("'", "").Trim() : "";
        _command.Code = _command.Code.HasValue() ? _command.Code.Replace("'", "").Trim() : "";
    }
}
