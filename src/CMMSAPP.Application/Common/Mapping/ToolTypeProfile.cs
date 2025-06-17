namespace CMMSAPP.Application.Common.Mapping;

public class ToolTypeProfile : Profile
{
    public ToolTypeProfile()
    {
        CreateMap<ToolType, ToolTypeDto>().ReverseMap();
    }
}