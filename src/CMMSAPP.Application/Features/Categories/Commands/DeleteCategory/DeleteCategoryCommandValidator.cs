namespace CMMSAPP.Application.Features.Categories.Commands.DeleteCategory;

public class DeleteCategoryCommandValidator : AbstractValidator<DeleteCategoryCommand>
{
    public DeleteCategoryCommandValidator()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("دسته تجهیزی با این مشخصات ثبت نشده است.");
    }
}