namespace CMMSAPP.Application.Features.Categories.Commands.UpdateVisit;

public class UpdateVisitCommandValidator : AbstractValidator<UpdateVisitCommand>
{
    public UpdateVisitCommandValidator()
    {
        RuleFor(p => p.Id)
    .NotEmpty().WithMessage("آیتمی با این مشخصات ثبت نشده است.");

        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("عنوان  را وارد نمایید.")
            .MinimumLength(2).WithMessage("تعداد کاراکترهای عنوان از حد مجاز (2 کاراکتر) می باشد.");

        RuleFor(x => x.Code)
        .NotEmpty().WithMessage("کد را وارد نمایید.");
    }
}