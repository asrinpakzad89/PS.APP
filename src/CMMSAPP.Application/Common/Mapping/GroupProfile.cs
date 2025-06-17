namespace CMMSAPP.Application.Common.Mapping;

public class GroupProfile : Profile
{
    public GroupProfile()
    {
        CreateMap<Group, GroupDto>().ReverseMap();
    }
}