using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentManagementSystem.Application.Common;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Infrastructure.Common;
using StudentManagementSystem.Infrastructure.Repositories;

namespace StudentManagementSystem.Infrastructure.Extensions
{
    public class InfrastructureExtension
    {
        public InfrastructureExtension(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}