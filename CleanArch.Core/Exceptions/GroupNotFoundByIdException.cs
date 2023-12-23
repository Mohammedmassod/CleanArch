using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Exceptions
{

    public class GroupNotFoundByIdException : Exception
    {
        public GroupNotFoundByIdException(int id) : base($"Group with id {id} was not found")
        {
        }
    }

}
