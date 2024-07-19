using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using StudentManagementSystem.Application.DTOs.Courses.Requests;
using StudentManagementSystem.Application.DTOs.Enrollments.Requests;
using StudentManagementSystem.Application.DTOs.Semesters.Requests;
using StudentManagementSystem.Application.DTOs.Users.Requests;
using StudentManagementSystem.Application.Helpers;
using StudentManagementSystem.Application.Interface.Helpers;
using StudentManagementSystem.Application.Interface.Services;
using StudentManagementSystem.Application.Mappings;
using StudentManagementSystem.Application.Services;
using StudentManagementSystem.Application.Validations.Courses;
using StudentManagementSystem.Application.Validations.Enrollments;
using StudentManagementSystem.Application.Validations.Semesters;
using StudentManagementSystem.Application.Validations.Users;
using StudentManagementSystem.Domain.Common;
using StudentManagementSystem.Domain.Enums;
using System.Text;

namespace StudentManagementSystem.Application.Extensions
{
    public class ServiceExtensions
    {
        public static void ConfigureServices(IServiceCollection service, IConfiguration configuration)
        {
            // injection service
            service.AddScoped<IUserHelper, UserHelper>();
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<ITokenService, TokenService>();
            service.AddScoped<IAuthService, AuthService>();
            service.AddScoped<ICourseService, CourseService>();
            service.AddScoped<ISemesterService, SemesterService>();
            service.AddScoped<IEnrollmentService, EnrollmentService>();

            //injection mapping
            service.AddAutoMapper(typeof(GeneralProfile));

            //inject validator
            service.AddScoped<IValidator<AddUserRequestDto>, AddUserRequestValidation>();
            service.AddScoped<IValidator<AddCourseRequestDto>, AddCourseRequestValidation>();
            service.AddScoped<IValidator<AddSemesterRequestDto>, AddSemesterRequestValidation>();
            service.AddScoped<IValidator<AddEnrollmentRequestDto>, AddEnrollmentRequestValidation>();
            service.AddScoped<IValidator<EditEnrollmentRequestDto>, EditEnrollmentRequestValidation>();

            var jwtSettings = service.Configure<JWTSettings>(configuration.GetSection("JWTSettings"));
            service.AddSingleton(jwtSettings);
            service.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(o =>
                {
                    o.RequireHttpsMetadata = false;
                    o.SaveToken = true;
                    o.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = configuration["JWTSettings:Issuer"],
                        ValidAudience = configuration["JWTSettings:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWTSettings:Key"]))
                    };
                });

            service.AddAuthorization(options =>
            {
                options.AddPolicy($"{RoleType.Admin}", policy => policy.RequireRole("Admin"));
                options.AddPolicy($"{RoleType.Student}", policy => policy.RequireRole("Student"));
            });
        }
    }
}