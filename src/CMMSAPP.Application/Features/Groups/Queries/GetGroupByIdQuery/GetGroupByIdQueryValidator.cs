namespace CMMSAPP.Application.Features.Groups.Queries.GetGroupByIdQuery;

public class GetGroupByIdQueryValidator : AbstractValidator<GetGroupByIdQuery>
{
    public GetGroupByIdQueryValidator()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("آیتم مورد نظر را انتخاب نمایید.");
    }
}