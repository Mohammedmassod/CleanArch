using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Exceptions
{
    public class PermissionNotFoundByIdException : Exception
    {
        public PermissionNotFoundByIdException(int id) : base($"Permission with id {id} was not found")
        {
        }
    }
}
