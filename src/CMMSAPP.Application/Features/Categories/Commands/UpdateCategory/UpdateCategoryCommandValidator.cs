using CMMSAPP.Application.Features.Categories.Commands.CreateCategory;

namespace CMMSAPP.Application.Features.Categories.Commands.UpdateCategory;

public class UpdateCategoryCommandValidator : AbstractValidator<UpdateCategoryCommand>
{
    public UpdateCategoryCommandValidator()
    {
        RuleFor(p => p.Id)
    .NotEmpty().WithMessage("دسته تجهیزی با این مشخصات ثبت نشده است.");

        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("عنوان دسته تجهیز را وارد نمایید.")
            .MinimumLength(2).WithMessage("تعداد کاراکترهای عنوان دسته کمتر از حد مجاز (2 کاراکتر) می باشد.");

        RuleFor(x => x.Code)
        .NotEmpty().WithMessage("کد دسته تجهیز را وارد نمایید.");

        RuleFor(x => x.GroupId)
       .NotEmpty().WithMessage("دسته تجهیز را انتخاب نمایید.");


    }
}