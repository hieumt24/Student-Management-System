using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentManagementSystem.Application.Common;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Infrastructure.Common;
using StudentManagementSystem.Infrastructure.DataAccess;
using StudentManagementSystem.Infrastructure.Repositories;

namespace StudentManagementSystem.Infrastructure.Extensions
{
    public class InfrastructureExtension
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            //injection of repositories
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ITokenRepository, TokenRepository>();
            services.AddScoped<ISemesterRepository, SemesterRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();

            //injection
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
                           options.UseSqlServer(connectionString));
        }
    }
}