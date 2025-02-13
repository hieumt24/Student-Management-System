﻿using AutoMapper;
using DocumentFormat.OpenXml.Office2016.Drawing.Command;
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
        private readonly ITokenRepository _tokenRepository;
        private readonly IBlackListTokenRepository _blackListTokenRepository;
        private readonly IEnrollmentRepository _enrollmentRepository;

        public UserService
        (
            IMapper mapper,
            IUserRepository userRepository,
            IValidator<AddUserRequestDto> addUserValidator,
            IUserHelper userHelper,
            ITokenRepository tokenRepository,
            IBlackListTokenRepository blackListTokenRepository,
            IEnrollmentRepository enrollmentRepository

        )
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _passwordHasher = new PasswordHasher<User>();
            _addUserValidator = addUserValidator;
            _userHelper = userHelper;
            _tokenRepository = tokenRepository;
            _blackListTokenRepository = blackListTokenRepository;
            _enrollmentRepository = enrollmentRepository;
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

                await _userRepository.AddStudentWithSemester(user.Id, Guid.Parse("64B90AB9-CA09-488B-ADED-E4134B344FD6"));

                var userDto = _mapper.Map<UserDto>(user);

                return new Response<UserDto> { Succeeded = true, Data = userDto };
            }
            catch (Exception ex)
            {
                return new Response<UserDto> { Succeeded = false, Errors = new List<string> { ex.Message } };
            }
        }

        public async Task<Response<UserDto>> DeleteUserAsync(Guid userId)
        {
            try
            {
                var user = await _userRepository.GetByIdAsync(userId);
                if (user == null)
                {
                    return new Response<UserDto> { Succeeded = false, Message = "User not found " };
                }

                user.LastModifiedOn = DateTime.Now;

                var deletedUser = await _userRepository.DeleteAsync(userId);
                if (deletedUser == null)
                {
                    return new Response<UserDto> { Succeeded = false, Message = "Deleted user failed" };
                }
                var token = await _tokenRepository.FindByUserIdAsync(deletedUser.Id);
                if (token != null)
                {
                    await _blackListTokenRepository.AddAsync(new BlackListToken
                    {
                        Token = token.Value,
                        CreatedOn = DateTime.Now
                    });
                }
                return new Response<UserDto> { Succeeded = true, Message = "User deleted successfully" };
            }
            catch (Exception ex)
            {
                return new Response<UserDto> { Succeeded = false, Errors = new List<string> { ex.Message } };
            }
        }

        public async Task<IQueryable<UserResponseDto>> GetAllOdataUserAsync()
        {
            try
            {
                var users = await _userRepository.GetAllAsync();
                if (users is null)
                {
                    return null;
                }
                var userResponseDto = _mapper.Map<List<UserResponseDto>>(users);
                return userResponseDto.AsQueryable();
            }
            catch (Exception ex)
            {
                return null;
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

        public async Task<Response<UserDto>> GetUserByIdAsync(Guid userId)
        {
            try
            {
                var exisitngUser = await _userRepository.GetByIdAsync(userId);
                if (exisitngUser == null)
                {
                    return new Response<UserDto> { Succeeded = false, Message = "User not found" };
                }
                var userDto = _mapper.Map<UserDto>(exisitngUser);
                return new Response<UserDto> { Succeeded = true, Data = userDto };
            }
            catch (Exception ex)
            {
                return new Response<UserDto> { Succeeded = false, Errors = new List<string> { ex.Message } };
            }
        }

        public async Task<Response<bool>> IsValidDeletedUser(Guid userId)
        {
            try
            {
                var exisitngUser = await _userRepository.GetByIdAsync(userId);
                if (exisitngUser == null)
                {
                    return new Response<bool> { Succeeded = false, Message = "User not found" };
                }
                var studentInEnrollment = await _enrollmentRepository.GetStudentInEnrollment(userId);
                if (studentInEnrollment != null)
                {
                    return new Response<bool> { Succeeded = false, Message = "User is in enrollment" };
                }
                return new Response<bool> { Succeeded = true, Message = "User is valid to delete" };
            }
            catch (Exception ex)
            {
                return new Response<bool> { Succeeded = false, Errors = new List<string> { ex.Message } };
            }
        }

        public async Task<Response<UserDto>> UpdateUserAsync(EditUserRequestDto request, Guid userId)
        {
            try
            {
                var user = _mapper.Map<User>(request);

                var exisitingUser = await _userRepository.GetByIdAsync(userId);
                if (exisitingUser is null)
                {
                    return new Response<UserDto> { Succeeded = false, Errors = new List<string> { "User not found" } };
                }

                exisitingUser.DateOfBirth = user.DateOfBirth;
                exisitingUser.JoinedDate = user.JoinedDate;
                exisitingUser.Gender = user.Gender;
                exisitingUser.LastModifiedOn = DateTime.Now;

                await _userRepository.UpdateAsync(exisitingUser);

                var userDto = _mapper.Map<UserDto>(exisitingUser);
                return new Response<UserDto> { Succeeded = true, Data = userDto };
            }
            catch (Exception ex)
            {
                return new Response<UserDto> { Succeeded = false, Errors = new List<string> { ex.Message } };
            }
        }
    }
}