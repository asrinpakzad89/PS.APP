namespace CMMSAPP.Application.Features.Groups.Commands.DeleteGroup;

public class DeleteGroupCommandValidator : AbstractValidator<DeleteGroupCommand>
{
    public DeleteGroupCommandValidator()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("کروهی با این مشخصات ثبت نشده است.");
    }
}