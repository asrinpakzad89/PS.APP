namespace CMMSAPP.Application.Features.Categories.Commands.UpdateStatus;

public class UpdateBreakdownStatusCommandValidator : AbstractValidator<UpdateBreakdownStatusCommand>
{
    public UpdateBreakdownStatusCommandValidator()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("آیتمی با این مشخصات ثبت نشده است.");
    }
}