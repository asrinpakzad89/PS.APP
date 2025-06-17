namespace CMMSAPP.Application.Features.Categories.Commands.UpdateStatus;

public class UpdateCategoryStatusCommandValidator : AbstractValidator<UpdateCategoryStatusCommand>
{
    public UpdateCategoryStatusCommandValidator()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("آیتمی با این مشخصات ثبت نشده است.");
    }
}