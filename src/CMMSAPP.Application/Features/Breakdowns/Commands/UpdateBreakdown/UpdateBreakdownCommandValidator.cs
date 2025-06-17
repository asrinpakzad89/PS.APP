namespace CMMSAPP.Application.Features.Categories.Commands.UpdateBreakdown;

public class UpdateBreakdownCommandValidator : AbstractValidator<UpdateBreakdownCommand>
{
    public UpdateBreakdownCommandValidator()
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