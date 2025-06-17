namespace CMMSAPP.Application.Features.Categories.Commands.DeleteBreakdown;

public class DeleteBreakdownCommandValidator : AbstractValidator<DeleteBreakdownCommand>
{
    public DeleteBreakdownCommandValidator()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("آیتمی با این مشخصات ثبت نشده است.");
    }
}