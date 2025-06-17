namespace CMMSAPP.Application.Features.ToolTypes.Commands.DeleteToolType;

public class DeleteToolTypeCommandValidator : AbstractValidator<DeleteToolTypeCommand>
{
    public DeleteToolTypeCommandValidator()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("آیتمی با این مشخصات ثبت نشده است.");
    }
}