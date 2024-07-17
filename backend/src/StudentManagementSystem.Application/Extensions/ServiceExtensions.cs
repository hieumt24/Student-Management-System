using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentManagementSystem.Application.DTOs.Users.Requests;
using StudentManagementSystem.Application.Helpers;
using StudentManagementSystem.Application.Interface.Helpers;
using StudentManagementSystem.Application.Interface.Services;
using StudentManagementSystem.Application.Mappings;
using StudentManagementSystem.Application.Services;
using StudentManagementSystem.Application.Validations.Users;

namespace StudentManagementSystem.Application.Extensions
{
    public class ServiceExtensions
    {
        public static void ConfigureServices(IServiceCollection service, IConfiguration configuration)
        {
            // injection service
            service.AddScoped<IUserHelper, UserHelper>();
            service.AddScoped<IUserService, UserService>();

            //injection mapping
            service.AddAutoMapper(typeof(GeneralProfile));

            //inject validator
            service.AddScoped<IValidator<AddUserRequestDto>, AddUserRequestValidation>();
        }
    }
}