namespace CMMSAPP.Application.Common.Mapping;

public class ToolProfile : Profile
{
    public ToolProfile()
    {
        CreateMap<Tool, ToolDto>().ReverseMap();
    }
}