namespace CMMSAPP.Application.Features.Tools.Commands.UpdateToolType;

public class UpdateToolTypeCommandValidator : AbstractValidator<UpdateToolTypeCommand>
{
    public UpdateToolTypeCommandValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("عنوان را وارد نمایید.")
            .MinimumLength(2).WithMessage("تعداد کاراکترهای عنوان کمتر از حد مجاز (2 کاراکتر) می باشد.");

        RuleFor(x => x.Group)
        .NotEmpty().WithMessage("گروه ابزار را وارد نمایید.");
    }
}