using CleanArch.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public class UserGroup : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public PermissionGroup PermissionGroup { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
