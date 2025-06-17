namespace CMMSAPP.Application.Features.Tools.Commands.UpdateStatusTool;

public class UpdateToolTypeStatusCommandValidator : AbstractValidator<UpdateToolTypeStatusCommand>
{
    public UpdateToolTypeStatusCommandValidator()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("آیتمی با این مشخصات ثبت نشده است.");
    }
}