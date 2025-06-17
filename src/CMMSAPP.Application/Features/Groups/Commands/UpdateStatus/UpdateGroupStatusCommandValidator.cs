namespace CMMSAPP.Application.Features.Groups.Commands.UpdateStatus;

public class UpdateGroupStatusCommandValidator : AbstractValidator<UpdateGroupStatusCommand>
{
    public UpdateGroupStatusCommandValidator()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("کروهی با این مشخصات ثبت نشده است.");
    }
}