using AutoMapper;
using StudentManagementSystem.Application.DTOs.Users.Requests;
using StudentManagementSystem.Application.DTOs.Users.Responses;
using StudentManagementSystem.Domain.Entities;

namespace StudentManagementSystem.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<AddUserRequestDto, User>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
        }
    }
}