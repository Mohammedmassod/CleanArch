using CleanArch.Application.Helpers;
using CleanArch.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Application.IServices
{
    public interface IPermissionService : IGeneralService<Permission>
    {
        
        // Other methods related to Permission services can be added here
    }
}
