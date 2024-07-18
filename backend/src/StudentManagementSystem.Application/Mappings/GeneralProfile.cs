using AutoMapper;
using StudentManagementSystem.Application.DTOs.Courses.Requests;
using StudentManagementSystem.Application.DTOs.Courses.Responses;
using StudentManagementSystem.Application.DTOs.Users.Requests;
using StudentManagementSystem.Application.DTOs.Users.Responses;
using StudentManagementSystem.Domain.Entities;

namespace StudentManagementSystem.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            //mapping for user
            CreateMap<AddUserRequestDto, User>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<UserResponseDto, User>().ReverseMap();

            //mapping for course
            CreateMap<CourseDto, Course>().ReverseMap();
            CreateMap<CourseResponseDto, Course>().ReverseMap();
            CreateMap<AddCourseRequestDto, Course>().ReverseMap();
        }
    }
}