namespace CMMSAPP.Application.Features.Categories.Queries.GetVisitByIdQuery;

public class GetVisitByIdQueryValidator : AbstractValidator<GetVisitByIdQuery>
{
    public GetVisitByIdQueryValidator()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("آیتم مورد نظر را انتخاب نمایید.");
    }
}