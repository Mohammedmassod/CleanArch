using CleanArch.Application.Interfaces;
using CleanArch.Domain.Entities;
using CleanArch.Domain.IRepositores;

namespace CleanArch.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        public UnitOfWork(IContactRepository contactRepository, IUserRepository userRepository,IPermissionRepository permission)
        {
            Contacts = contactRepository;
            Users = userRepository;
            Permissions = permission;
        }

        public IContactRepository Contacts { get; set; }
        public IUserRepository Users { get; set; }
        public IPermissionRepository Permissions { get; set; }


        // تنفيذ الخاصية المطلوبة من IUnitOfWork





    }
}
