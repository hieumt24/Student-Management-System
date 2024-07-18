using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Infrastructure.DataAccess;
using StudentManagementSystem.WebApi.Middlewares;

namespace StudentManagementSystem.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                         options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
                         b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
            ));

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            builder.Services.AddControllers().AddOData(option =>
            {
                option.Select()
                        .Filter()
                        .Count()
                        .OrderBy()
                        .Expand()
                        .SetMaxTop(100);
                option.AddRouteComponents("odata", GetEdmModel()).RouteOptions.EnableKeyInParenthesis = false;
            });

            Application.Extensions.ServiceExtensions.ConfigureServices(builder.Services, builder.Configuration);
            Infrastructure.Extensions.InfrastructureExtension.Configure(builder.Services, builder.Configuration);
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors("AllowAllOrigins");

            app.UseMiddleware<TokenValidationMiddleware>();

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }

        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new();
            builder.EntitySet<User>("Users");
            builder.EntitySet<Course>("Courses");
            builder.EntitySet<Semester>("Semesters");
            builder.EntitySet<Enrollment>("Enrollments");

            return builder.GetEdmModel();
        }
    }
}