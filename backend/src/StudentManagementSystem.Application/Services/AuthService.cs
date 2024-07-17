using Microsoft.AspNetCore.Identity;
using StudentManagementSystem.Application.DTOs.Auth.Requests;
using StudentManagementSystem.Application.DTOs.Auth.Responses;
using StudentManagementSystem.Application.DTOs.Users.Requests;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Application.Interface.Services;
using StudentManagementSystem.Application.Wrappers;
using StudentManagementSystem.Domain.Entities;

namespace StudentManagementSystem.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly PasswordHasher<User> _passwordHasher = new PasswordHasher<User>();
        private readonly ITokenService _tokenService;
        private readonly ITokenRepository _tokenRepository;

        public AuthService(IUserRepository userRepository, ITokenService tokenService, ITokenRepository tokenRepository)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
            _tokenRepository = tokenRepository;
        }

        public Task<Response<string>> ChangePasswordAsync(ChangePasswordRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<AuthenticationResponse>> LoginAsync(AuthenticationRequest request)
        {
            var user = await _userRepository.FindByUserNameAndEmail(request.Username, request.Email);
            if (user is null)
            {
                return new Response<AuthenticationResponse> { Succeeded = false, Message = "Login information is incorrect. Please check again." };
            }
            var verificationResult = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, request.Password);

            if (verificationResult != PasswordVerificationResult.Success)
            {
                return new Response<AuthenticationResponse> { Succeeded = false, Message = "Login information is incorrect. Please check again." };
            }

            var role = await _userRepository.GetRoleAsync(user.Id);
            var token = await _tokenService.GenerateJwtToken(user, role);
            var response = new AuthenticationResponse { Username = user.UserName, Email = user.Email, Role = role.ToString(), Token = token };

            var existingToken = await _tokenRepository.FindByUserIdAsync(user.Id);
            if (existingToken is not null)
            {
                existingToken.Value = token;
                existingToken.CreatedOn = DateTime.Now;
                await _tokenRepository.UpdateAsync(existingToken);
            }
            else
            {
                await _tokenRepository.AddAsync(new Token { UserId = user.Id, Value = token });
            }

            return new Response<AuthenticationResponse> { Succeeded = true, Data = response };
        }
    }
}