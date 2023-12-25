using CleanArch.Domain.Common;
using CleanArch.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public class Group : BaseDomainEntity
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public PermissionGroup PermissionGroup { get; set; }

        public ICollection<User> Users { get; set; }
        public Status State { get;  set; }

    }

}
