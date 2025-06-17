namespace CMMSAPP.Application.Features.Tools.Queries.GetToolByIdQuery;

internal class GetToolByIdQueryValidator : AbstractValidator<GetToolByIdQuery>
{
    public GetToolByIdQueryValidator()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("آیتم مورد نظر را انتخاب نمایید.");
    }
}