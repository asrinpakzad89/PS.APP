namespace CMMSAPP.Application.Common.Mapping;

public class VisitProfile : Profile
{
    public VisitProfile()
    {
        CreateMap<Visit, VisitDto>().ReverseMap();
    }
}