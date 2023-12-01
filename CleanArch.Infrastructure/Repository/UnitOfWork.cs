using CleanArch.Application.Interfaces;
using CleanArch.Domain.IRepositores;

namespace CleanArch.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        
        public UnitOfWork(IContactRepository contactRepository)
        {
            Contacts = contactRepository;
        }

        public IContactRepository Contacts { get; set; }

        

        
    }
}
