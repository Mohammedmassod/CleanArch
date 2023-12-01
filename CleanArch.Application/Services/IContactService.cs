using CleanArch.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public interface IContactService
    {
        Task<ApiResponse<List<Contact>>> GetAllContacts();
        Task<ApiResponse<Contact>> GetContactById(int id);
        Task<ApiResponse<string>> AddContact(Contact contact);
        Task<ApiResponse<string>> UpdateContact(Contact contact);
        Task<ApiResponse<string>> DeleteContact(int id);
    }
}
