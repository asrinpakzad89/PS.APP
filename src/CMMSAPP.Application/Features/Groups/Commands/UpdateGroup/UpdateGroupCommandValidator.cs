namespace CMMSAPP.Application.Features.Groups.Commands.UpdateGroup;

public class UpdateGroupCommandValidator : AbstractValidator<UpdateGroupCommand>
{
    public UpdateGroupCommandValidator()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("گروهی با این مشخصات ثبت نشده است.");

        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("عنوان گروه را وارد نمایید.")
            .MinimumLength(2).WithMessage("تعداد کاراکترهای وارد شده کمتر از حد مجاز (2 کاراکتر) می باشد.");
    }
}