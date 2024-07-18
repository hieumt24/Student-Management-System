using AutoMapper;
using StudentManagementSystem.Application.DTOs.Courses.Requests;
using StudentManagementSystem.Application.DTOs.Courses.Responses;
using StudentManagementSystem.Application.DTOs.Semesters.Requests;
using StudentManagementSystem.Application.DTOs.Semesters.Responses;
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
            CreateMap<Course, CourseResponseDto>().
                ForMember(dest => dest.SemesterName, opt => opt.MapFrom(src => src.Semester.SemesterName))
                .ForMember(dest => dest.SemesterCode, opt => opt.MapFrom(src => src.Semester.SemesterCode))
                .ForMember(dest => dest.AcademicYear, opt => opt.MapFrom(src => src.Semester.AcademicYear))
                .ReverseMap()
                ;
            CreateMap<AddCourseRequestDto, Course>().ReverseMap();

            //mapping for semestes
            CreateMap<SemesterDto, Semester>().ReverseMap();
            CreateMap<AddSemesterRequestDto, Semester>().ReverseMap();
            CreateMap<Semester, SemesterResponseDto>().ReverseMap();
        }
    }
}