namespace CMMSAPP.Application.Features.Categories.Commands.UpdateStatus;

public class UpdateVisitStatusCommandValidator : AbstractValidator<UpdateVisitStatusCommand>
{
    public UpdateVisitStatusCommandValidator()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("آیتمی با این مشخصات ثبت نشده است.");
    }
}