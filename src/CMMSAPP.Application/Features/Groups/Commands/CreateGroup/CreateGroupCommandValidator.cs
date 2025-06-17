namespace CMMSAPP.Application.Features.Groups.Commands.CreateGroup;

public class CreateGroupCommandValidator : AbstractValidator<CreateGroupCommand>
{
    public CreateGroupCommandValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("عنوان گروه را وارد نمایید.")
            .MinimumLength(2).WithMessage("تعداد کاراکترهای عنوان گروه کمتر از حد مجاز (2 کاراکتر) می باشد.");
    }
}