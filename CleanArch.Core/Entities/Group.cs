using CleanArch.Domain.Common;
using CleanArch.Domain.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CleanArch.Domain.Entities
{
    public class Group : BaseDomainEntity
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name length should not exceed 50 characters.")]
        public string Name { get; set; }

        public string Description { get; set; }

        public PermissionGroup PermissionGroup { get; set; }

        public ICollection<User> Users { get; set; }

        [Required(ErrorMessage = "State is required.")]
        public Status State { get; set; }
    }
}
