namespace CMMSAPP.Application.Features.Categories.Commands.CreateCategory;

public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
{
    public CreateCategoryCommandValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("عنوان دسته را وارد نمایید.")
            .MinimumLength(2).WithMessage("تعداد کاراکترهای عنوان دسته کمتر از حد مجاز (2 کاراکتر) می باشد.");

        RuleFor(x => x.Code)
        .NotEmpty().WithMessage("کد دسته را وارد نمایید.");

        RuleFor(x => x.GroupId)
       .NotEmpty().WithMessage("گروه را انتخاب نمایید.");
    }
}