using CleanArch.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public class PermissionGroup : BaseDomainEntity
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        public ICollection<Permission> Permissions { get; set; }
    }
}
