namespace CMMSAPP.Application.Features.Tools.Commands.CreateTool;

public class CreateToolCommandValidator : AbstractValidator<CreateToolCommand>
{
    public CreateToolCommandValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("عنوان را وارد نمایید.")
            .MinimumLength(2).WithMessage("تعداد کاراکترهای عنوان کمتر از حد مجاز (2 کاراکتر) می باشد.");

        RuleFor(x => x.Code)
        .NotEmpty().WithMessage("کد را وارد نمایید.");
    }
}