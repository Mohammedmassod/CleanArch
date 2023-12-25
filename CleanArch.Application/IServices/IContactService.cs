using CleanArch.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Application.IServices
{
    public interface IContactService : IGeneralService<Contact>
    {
        /*Task<ApiResponse<List<Contact>>> GetAll();
        Task<ApiResponse<Contact>> GetById(int id);
        Task<ApiResponse<string>> Add(Contact contact);
        Task<ApiResponse<string>> Update(Contact contact);
        Task<ApiResponse<string>> Delete(int id);*/
    }
}
