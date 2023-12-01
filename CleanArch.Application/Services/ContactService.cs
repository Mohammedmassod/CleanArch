using CleanArch.Domain.Entities;
using CleanArch.Application.Interfaces;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using CleanArch.Application.Helpers;

namespace CleanArch.Application.Services
{
    public class ContactService : IContactService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse<string>> AddContact(Contact contact)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                var data = await _unitOfWork.Contacts.AddAsync(contact);
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

        public async Task<ApiResponse<string>> DeleteContact(int id)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                var data = await _unitOfWork.Contacts.DeleteAsync(id);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            catch (SqlException ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

       
        public async Task<ApiResponse<List<Contact>>> GetAllContacts()
        {
            var apiResponse = new ApiResponse<List<Contact>>();

            try
            {
                var data = await _unitOfWork.Contacts.GetAllAsync();
                apiResponse.Success = true;
                apiResponse.Result = data.ToList();
            }
            catch (SqlException ex)
            {
                return ApiResponseHelper.HandleError<List<Contact>>(ex);
            }
            catch (Exception ex)
            {
                return ApiResponseHelper.HandleError<List<Contact>>(ex);
            }

            return apiResponse;
        }

        public async Task<ApiResponse<Contact>> GetContactById(int id)
        {

            var apiResponse = new ApiResponse<Contact>();

            try
            {
                var data = await _unitOfWork.Contacts.GetByIdAsync(id);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            catch (SqlException ex)
            {
                return ApiResponseHelper.HandleError<Contact>(ex);

            }
            catch (Exception ex)
            {
                return ApiResponseHelper.HandleError<Contact>(ex);

            }

            return apiResponse;
        }

        public async Task<ApiResponse<string>> UpdateContact(Contact contact)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                var data = await _unitOfWork.Contacts.UpdateAsync(contact);
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

    }
}
