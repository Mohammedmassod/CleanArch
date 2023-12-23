using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Exceptions
{
    public class UserNotFoundByIdException : Exception
    {
        public UserNotFoundByIdException(int id) : base($"User with id {id} was not found")
        {
        }
    }
}
