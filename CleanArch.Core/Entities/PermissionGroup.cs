using CleanArch.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public class PermissionGroup : Entity
    {
        public string Name { get; set; }

        public ICollection<Permission> Permissions { get; set; }
    }
}
