using CleanArch.Domain.Entities;
using CleanArch.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.IRepositores
{
    public interface IUserRepository: IRepository<User>
    {
        Task ChangePasswordAsync(int userId, string newPassword);
        Task ChangeUserStatusAsync(int userId, Status newStatus);

    }
}
