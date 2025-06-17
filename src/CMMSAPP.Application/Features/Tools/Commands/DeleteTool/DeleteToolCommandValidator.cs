namespace CMMSAPP.Application.Features.Tools.Commands.DeleteTool;

public class DeleteToolCommandValidator : AbstractValidator<DeleteToolCommand>
{
    public DeleteToolCommandValidator()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("آیتمی با این مشخصات ثبت نشده است.");
    }
}