using AutoMapper;
using DataAccessLayer.Dto;
using DataAccessLayer.Model;

namespace DataAccessLayer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
        }
    }
}
