using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StudentManagementSystem.Domain.Common;
using StudentManagementSystem.Infrastructure.DataAccess;

namespace StudentManagementSystem.WebApi.Middlewares
{
    public class TokenValidationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly JWTSettings _jwtSettings;
        private readonly ILogger<TokenValidationMiddleware> _logger;

        public TokenValidationMiddleware(RequestDelegate next, IOptions<JWTSettings> jwtSettings, ILogger<TokenValidationMiddleware> logger)
        {
            _next = next;
            _jwtSettings = jwtSettings.Value;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, ApplicationDbContext _dbContext)
        {
            if (context.Request.Path.StartsWithSegments("/api/v1/auth/login"))
            {
                await _next(context);
                return;
            }

            var token = context.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

            var blackListToken = await _dbContext.BlackListTokens.FirstOrDefaultAsync(x => x.Token == token);
            if (blackListToken != null)
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Unauthorized request: Token is blacklisted");
                _logger.LogInformation("Unauthorized request: Token is blacklisted");
                return;
            }

            await _next(context);
        }
    }
}