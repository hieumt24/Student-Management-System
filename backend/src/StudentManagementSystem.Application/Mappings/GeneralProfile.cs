using AutoMapper;
using StudentManagementSystem.Application.DTOs.Courses.Requests;
using StudentManagementSystem.Application.DTOs.Courses.Responses;
using StudentManagementSystem.Application.DTOs.Enrollments.Requests;
using StudentManagementSystem.Application.DTOs.Enrollments.Responses;
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
            CreateMap<Course, CourseResponseDto>()
                .ReverseMap();
            CreateMap<AddCourseRequestDto, Course>().ReverseMap();

            //mapping for semestes
            CreateMap<SemesterDto, Semester>().ReverseMap();
            CreateMap<AddSemesterRequestDto, Semester>().ReverseMap();
            CreateMap<Semester, SemesterResponseDto>().ReverseMap();

            //maping for enrollment
            CreateMap<EnrollmentDto, Enrollment>().ReverseMap();
            CreateMap<AddEnrollmentRequestDto, Enrollment>().ReverseMap();
            CreateMap<Enrollment, EnrollmentResponseDto>()
                .ForMember(dest => dest.StudentName, opt => opt.MapFrom(src => src.Student.FirstName + " " + src.Student.LastName))
                .ForMember(dest => dest.CourseCode, opt => opt.MapFrom(src => src.Course.CourseCode))
                .ForMember(dest => dest.SemesterCode, opt => opt.MapFrom(src => src.Semester.SemesterCode))
                .ReverseMap();
            CreateMap<EditEnrollmentRequestDto, Enrollment>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.EnrollmentId))
                .ReverseMap();

            CreateMap<Enrollment, StudentEnrollmentResponseDto>()
                .ForMember(dest => dest.SemesterCode, opt => opt.MapFrom(src => src.Semester.SemesterCode))
                .ForMember(dest => dest.CourseCode, opt => opt.MapFrom(src => src.Course.CourseCode))
                .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Title))
                .ForMember(dest => dest.Level, opt => opt.MapFrom(src => src.Course.Level))
                .ForMember(dest => dest.Credits, opt => opt.MapFrom(src => src.Course.Credits))
                .ReverseMap();
        }
    }
}