using CleanArch.Domain.Entities;
using CleanArch.Application.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Application.IServices
{
    public interface IUserService
    {
        Task<ApiResponse<string>> Create(User user);
        Task<ApiResponse<string>> Update(User user);
        Task<ApiResponse<string>> DeleteUser(int id);
        Task<ApiResponse<User>> GetUserById(int id);
        Task<ApiResponse<List<User>>> GetAllUsers();
        // يمكنك إضافة المزيد من الطرق حسب احتياجات التطبيق
    }
}
