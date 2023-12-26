using CleanArch.Application.Interfaces;
using CleanArch.Domain.Entities;
using CleanArch.Application.IRepositores;

namespace CleanArch.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        public UnitOfWork( 
            IUserRepository userRepository,IPermissionRepository permission,IGroupRepository groupRepository ,
            IPermissionGroupRepository permissionGroup)
        {
            Users = userRepository;
            Permissions = permission;
            Groups = groupRepository;
            PermissinsGroup = permissionGroup;
        }

        public IUserRepository Users { get; set; }
        public IPermissionRepository Permissions { get; set; }
        public IGroupRepository Groups { get; set; }

        public IPermissionGroupRepository PermissinsGroup { get; set; }


        // تنفيذ الخاصية المطلوبة من IUnitOfWork





    }
}
