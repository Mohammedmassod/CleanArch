using CleanArch.Application.Helpers;
using CleanArch.Application.IServices;
using CleanArch.Domain.Entities;
using CleanArch.Domain.IRepositores;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;

        public PermissionService(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
            //?? throw new ArgumentNullException(nameof(permissionRepository));
        }

        public async Task<ApiResponse<string>> Add(Permission permission)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                var data = await _permissionRepository.AddAsync(permission);
                apiResponse.Success = true;
                apiResponse.Result = data;
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

        public async Task<ApiResponse<string>> Update(Permission permission)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                var data = await _permissionRepository.UpdateAsync(permission);
                apiResponse.Success = true;
                apiResponse.Result = data;
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

        public async Task<ApiResponse<string>> Delete(int id)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                var data = await _permissionRepository.DeleteAsync(id);
                apiResponse.Success = true;
                apiResponse.Result = data;
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

        public async Task<ApiResponse<Permission>> GetById(int id)
        {
            var apiResponse = new ApiResponse<Permission>();

            try
            {
                var data = await _permissionRepository.GetByIdAsync(id);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            catch (SqlException ex)
            {
                return ApiResponseHelper.HandleError<Permission>(ex);
            }
            catch (Exception ex)
            {
                return ApiResponseHelper.HandleError<Permission>(ex);
            }

            return apiResponse;
        }

        public async Task<ApiResponse<List<Permission>>> GetAll()
        {
            var apiResponse = new ApiResponse<List<Permission>>();

            try
            {
                var data = await _permissionRepository.GetAllAsync();
                apiResponse.Success = true;
                apiResponse.Result = data.ToList(); // Convert IReadOnlyList to List
            }
            catch (SqlException ex)
            {
                return ApiResponseHelper.HandleError<List<Permission>>(ex);
            }
            catch (Exception ex)
            {
                return ApiResponseHelper.HandleError<List<Permission>>(ex);
            }

            return apiResponse;
        }

       
    }
}
