using CleanArch.Domain.Common;
using CleanArch.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace CleanArch.Domain.Entities
{
    public class Permission : BaseDomainEntity
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Level is required.")]
        public PermissionLevel Level { get; set; }

        public Permission(string name, string description, PermissionLevel level)
        {
            Name = name;
            Level = level;
            Description = description;
        }
    }
}
