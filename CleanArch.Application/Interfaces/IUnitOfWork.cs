using CleanArch.Domain.IRepositores;

namespace CleanArch.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IContactRepository Contacts { get; }

         
    }
}
