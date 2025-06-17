namespace CMMSAPP.Application.Features.Categories.Queries.GetBreakdownByIdQuery;

public class GetBreakdownByIdQueryValidator : AbstractValidator<GetBreakdownByIdQuery>
{
    public GetBreakdownByIdQueryValidator()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("آیتم مورد نظر را انتخاب نمایید.");
    }
}