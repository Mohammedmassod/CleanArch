using CleanArch.Domain.Entities;
using CleanArch.Application.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArch.Application;

public interface IGeneralService<TEntity>
{
    Task<ApiResponse<string>> Add(TEntity entity);
    Task<ApiResponse<string>> Update(TEntity entity);
    Task<ApiResponse<string>> Delete(int id);
    Task<ApiResponse<TEntity>> GetById(int id);
    Task<ApiResponse<List<TEntity>>> GetAll();
    // يمكنك إضافة المزيد من الطرق حسب احتياجات التطبيق
}
