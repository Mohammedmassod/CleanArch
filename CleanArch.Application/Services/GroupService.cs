using CleanArch.Application.Helpers;
using CleanArch.Application.Interfaces;
using CleanArch.Application.IServices;
using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class GroupService : IGroupService
    {
        private readonly IUnitOfWork _unitOfWork;

        public GroupService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<ApiResponse<string>> Add(Group entity)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                await _unitOfWork.Groups.AddAsync(entity);
               

                apiResponse.Success = true;
                apiResponse.Result = "Group added successfully.";
            }
            catch (Exception ex)
            {
                return ApiResponseHelper.HandleError<string>(ex);
            }

            return apiResponse;
        }

        public async Task<ApiResponse<string>> Update(Group entity)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                _unitOfWork.Groups.UpdateAsync(entity);

                apiResponse.Success = true;
                apiResponse.Result = "Group updated successfully.";
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
                var group = await _unitOfWork.Groups.GetByIdAsync(id);
                if (group == null)
                {
                    apiResponse.Success = false;
                    apiResponse.Message = "Group not found.";
                    return apiResponse;
                }

                _unitOfWork.Groups.DeleteAsync(id);

                apiResponse.Success = true;
                apiResponse.Result = "Group deleted successfully.";
            }
            catch (Exception ex)
            {
                return ApiResponseHelper.HandleError<string>(ex);
            }

            return apiResponse;
        }

        public async Task<ApiResponse<Group>> GetById(int id)
        {
            var apiResponse = new ApiResponse<Group>();

            try
            {
                var group = await _unitOfWork.Groups.GetByIdAsync(id);
                apiResponse.Success = true;
                apiResponse.Result = group;
            }
            catch (Exception ex)
            {
                return ApiResponseHelper.HandleError<Group>(ex);
            }

            return apiResponse;
        }

        public async Task<ApiResponse<List<Group>>> GetAll()
        {
            var apiResponse = new ApiResponse<List<Group>>();

            try
            {
                var data = await _unitOfWork.Groups.GetAllAsync();
                apiResponse.Success = true;
                apiResponse.Result = data.ToList(); // Convert IReadOnlyList to List
            }
            catch (Exception ex)
            {
                return ApiResponseHelper.HandleError<List<Group>>(ex);
            }

            return apiResponse;
        }
    }
}
