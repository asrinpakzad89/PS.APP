namespace CMMSAPP.Application.Features.Tools.Commands.UpdateStatusTool;

public class UpdateToolStatusCommandValidator : AbstractValidator<UpdateToolStatusCommand>
{
    public UpdateToolStatusCommandValidator()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("آیتمی با این مشخصات ثبت نشده است.");
    }
}