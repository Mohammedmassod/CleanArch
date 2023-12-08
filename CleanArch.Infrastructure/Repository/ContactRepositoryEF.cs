using CleanArch.Domain.Entities;
using CleanArch.Domain.IRepositores;
using CleanArch.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.Repository
{
    public class ContactRepositoryEF : IContactRepository
    {
        private readonly AppDbContext dbContext;

        public ContactRepositoryEF(AppDbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<IReadOnlyList<Contact>> GetAllAsync()
        {
            return await dbContext.Contact.ToListAsync();
        }

        /* public async Task<Contact> GetByIdAsync(long id)
         {
             return await dbContext.Contact.FindAsync(id);
         }*/
        public async Task<Contact> GetByIdAsync(int id)
        {
            return await dbContext.Contact.FindAsync(id);
        }

        public async Task<string> AddAsync(Contact entity)
        {
            dbContext.Contact.Add(entity);
            await dbContext.SaveChangesAsync();
            return "Added successfully!";
        }

        public async Task<string> UpdateAsync(Contact entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
            return "Updated successfully!";
        }

        public async Task<string> DeleteAsync(int id)
        {
            var contact = await dbContext.Contact.FindAsync(id);
            if (contact == null)
            {
                return "Contact not found!";
            }

            dbContext.Contact.Remove(contact);
            await dbContext.SaveChangesAsync();
            return "Deleted successfully!";
        }
    }
}
