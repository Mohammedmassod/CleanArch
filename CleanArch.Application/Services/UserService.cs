using CleanArch.Domain.Entities;
using CleanArch.Application.Helpers;
using CleanArch.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using CleanArch.Application.IServices;

namespace CleanArch.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse<string>> Create(User user)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                await _unitOfWork.Users.AddAsync(user);
                apiResponse.Success = true;
                apiResponse.Result = "User created successfully.";
            }
            catch (SqlException ex)
            {
                return ApiResponseHelper.HandleError<string>(ex);
            }
            catch (Exception ex)
            {
                return ApiResponseHelper.HandleError<string>(ex);
            }

            return apiResponse;
        }

        public async Task<ApiResponse<string>> Update(User user)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                await _unitOfWork.Users.UpdateAsync(user);
                apiResponse.Success = true;
                apiResponse.Result = "User updated successfully.";
            }
            catch (SqlException ex)
            {
                return ApiResponseHelper.HandleError<string>(ex);
            }
            catch (Exception ex)
            {
                return ApiResponseHelper.HandleError<string>(ex);
            }

            return apiResponse;
        }

        public async Task<ApiResponse<string>> DeleteUser(int id)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                await _unitOfWork.Users.DeleteAsync(id);
                apiResponse.Success = true;
                apiResponse.Result = "User deleted successfully.";
            }
            catch (SqlException ex)
            {
                return ApiResponseHelper.HandleError<string>(ex);
            }
            catch (Exception ex)
            {
                return ApiResponseHelper.HandleError<string>(ex);
            }

            return apiResponse;
        }

        public async Task<ApiResponse<User>> GetUserById(int id)
        {
            var apiResponse = new ApiResponse<User>();

            try
            {
                var user = await _unitOfWork.Users.GetByIdAsync(id);
                apiResponse.Success = true;
                apiResponse.Result = user;
            }
            catch (SqlException ex)
            {
                return ApiResponseHelper.HandleError<User>(ex);
            }
            catch (Exception ex)
            {
                return ApiResponseHelper.HandleError<User>(ex);
            }

            return apiResponse;
        }

        public async Task<ApiResponse<List<User>>> GetAllUsers()
        {
            var apiResponse = new ApiResponse<List<User>>();

            try
            {
                var users = await _unitOfWork.Users.GetAllAsync();
                apiResponse.Success = true;
                apiResponse.Result = users.ToList(); // هنا استخدم ToList() للتحويل الصريح
            }
            catch (SqlException ex)
            {
                return ApiResponseHelper.HandleError<List<User>>(ex);
            }
            catch (Exception ex)
            {
                return ApiResponseHelper.HandleError<List<User>>(ex);
            }

            return apiResponse;
        }

    }
}
