using AutoMapper;

namespace AutoMapperApi
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProjectDTO, Project>().ReverseMap(); //reverse so the both direction
        }
    }
}
