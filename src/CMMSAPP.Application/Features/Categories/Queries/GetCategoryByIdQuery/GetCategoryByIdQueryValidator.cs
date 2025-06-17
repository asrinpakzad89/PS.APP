namespace CMMSAPP.Application.Features.Categories.Queries.GetCategoryByIdQuery;

public class GetCategoryByIdQueryValidator : AbstractValidator<GetCategoryByIdQuery>
{
    public GetCategoryByIdQueryValidator()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("آیتم مورد نظر را انتخاب نمایید.");
    }
}