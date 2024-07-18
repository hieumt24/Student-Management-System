using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using StudentManagementSystem.Application.DTOs.Users.Requests;
using StudentManagementSystem.Application.DTOs.Users.Responses;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Helpers;
using StudentManagementSystem.Application.Interface.Helpers;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Application.Interface.Services;
using StudentManagementSystem.Application.Wrappers;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IValidator<AddUserRequestDto> _addUserValidator;
        private readonly PasswordHasher<User> _passwordHasher;
        private readonly IUserHelper _userHelper;

        public UserService
            (
            IMapper mapper,
            IUserRepository userRepository,
            IValidator<AddUserRequestDto> addUserValidator,
            IUserHelper userHelper
            )
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _passwordHasher = new PasswordHasher<User>();
            _addUserValidator = addUserValidator;
            _userHelper = userHelper;
        }

        public async Task<Response<UserDto>> AddUserAsync(AddUserRequestDto request)
        {
            var validationResult = await _addUserValidator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
                return new Response<UserDto> { Succeeded = false, Errors = errors };
            }
            try
            {
                var user = _mapper.Map<User>(request);

                user.UserName = await _userHelper.GenerateUserName(user.FirstName, user.LastName);
                user.PasswordHash = _passwordHasher.HashPassword(user, _userHelper.GenerateDefaultPassword(user.UserName, user.DateOfBirth));
                user.StudentCode = await _userHelper.GenerateStudentCode();
                user.Email = await _userHelper.GenerateUserEmail(user.UserName, user.StudentCode);
                user.IsDeleted = false;
                user.CreatedOn = DateTime.Now;

                await _userRepository.AddAsync(user);

                var userDto = _mapper.Map<UserDto>(user);

                return new Response<UserDto> { Succeeded = true, Data = userDto };
            }
            catch (Exception ex)
            {
                return new Response<UserDto> { Succeeded = false, Errors = new List<string> { ex.Message } };
            }
        }

        public async Task<PagedResponse<List<UserResponseDto>>> GetAllUserAsync(PaginationFilter? pagination, LocationType location, string? search, RoleType? role, string? orderBy, bool? isDescending)
        {
            try
            {
                var users = await _userRepository.GetAllMatchingUserAsync(pagination, location, search, role, orderBy, isDescending);

                if (users.Data is null)
                {
                    return new PagedResponse<List<UserResponseDto>> { Succeeded = false, Errors = new List<string> { "No users found" } };
                }
                var userResponseDto = _mapper.Map<List<UserResponseDto>>(users.Data);

                var pagedResponse = PaginationHelper.CreatePageResponse(userResponseDto, pagination, users.TotalRecords);

                return pagedResponse;
            }
            catch (Exception ex)
            {
                return new PagedResponse<List<UserResponseDto>> { Succeeded = false, Errors = new List<string> { ex.Message } };
            }
        }
    }
}