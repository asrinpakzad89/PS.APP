namespace CMMSAPP.Application.Common.Mapping;

public class BreakdownProfile : Profile
{
    public BreakdownProfile()
    {
        CreateMap<Breakdown, BreakdownDto>().ReverseMap();
    }
}