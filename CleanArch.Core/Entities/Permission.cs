using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Domain.Common;
using CleanArch.Domain.Enums;
namespace CleanArch.Domain.Entities
{
    public class Permission : BaseDomainEntity
    {
        public string Name { get; set; }
        public string Description { get;  set; }

        public PermissionLevel Level { get; }


        public Permission(string name, string description, PermissionLevel level)
        {
            Name = name;
            Level = level;
            Description = description;

        }
    }
}
