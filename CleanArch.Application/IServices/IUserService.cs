using CleanArch.Domain.Entities;
using CleanArch.Application.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Application.IServices
{
    public interface IUserService : IGeneralService<User>
    {
       /* Task<ApiResponse<string>> Add(User user);
        Task<ApiResponse<string>> Update(User user);
        Task<ApiResponse<string>> Delete(int id);
        Task<ApiResponse<User>> GetById(int id);
        Task<ApiResponse<List<User>>> GetAll();*/
        // يمكنك إضافة المزيد من الطرق حسب احتياجات التطبيق
    }
}
