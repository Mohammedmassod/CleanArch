using CleanArch.Application.IRepositores;

namespace CleanArch.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        IPermissionRepository Permissions { get; }
        IGroupRepository Groups { get; }
        IPermissionGroupRepository PermissinsGroup { get; }


    }
}
