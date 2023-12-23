using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Exceptions
{
    public class GroupAlreadyExistsException : Exception
    {
        public GroupAlreadyExistsException(string message) : base(message)
        {
        }
    }
}
