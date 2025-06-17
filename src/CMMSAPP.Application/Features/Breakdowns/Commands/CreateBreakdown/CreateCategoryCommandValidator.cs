namespace CMMSAPP.Application.Features.Categories.Commands.CreateBreakdown;

public class CreateBreakdownCommandValidator : AbstractValidator<CreateBreakdownCommand>
{
    public CreateBreakdownCommandValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("عنوان را وارد نمایید.")
            .MinimumLength(2).WithMessage("تعداد کاراکترهای عنوان کمتر از حد مجاز (2 کاراکتر) می باشد.");

        RuleFor(x => x.Code)
        .NotEmpty().WithMessage("کد را وارد نمایید.");
    }
}