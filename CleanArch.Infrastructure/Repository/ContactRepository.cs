using CleanArch.Domain.Entities;
using CleanArch.Domain.IRepositores;
using CleanArch.Infrastructure.Queries;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CleanArch.Infrastructure.Repository
{
    public class ContactRepository : IContactRepository
    {
        #region ===[ Private Members ]=============================================================

        private readonly IConfiguration configuration;

        #endregion

        #region ===[ Constructor ]=================================================================

        public ContactRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        #endregion

        #region ===[ IContactRepository Methods ]==================================================

        public async Task<IReadOnlyList<Contact>> GetAllAsync()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Contact>(ContactQueries.AllContact);
                return result.ToList();
            }
        }

        public async Task<Contact> GetByIdAsync(int id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Contact>(ContactQueries.ContactById, new { ContactId = id });
                return result;
            }
        }

        public async Task<string> AddAsync(Contact entity)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(ContactQueries.AddContact, entity);
                return result.ToString();
            }
        }

        public async Task<string> UpdateAsync(Contact entity)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(ContactQueries.UpdateContact, entity);
                return result.ToString();
            }
        }

        public async Task<string> DeleteAsync(int id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(ContactQueries.DeleteContact, new { ContactId = id });
                return result.ToString();
            }
        }

        #endregion
    }
}
