using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Domain.Common;
using CleanArch.Domain.Enums;
namespace CleanArch.Domain.Entities
{
    public class Permission : CleanArch.Domain.Common.ValueObject
    {
        public string Name { get; }

        public PermissionLevel Level { get; }

        public Permission(string name, PermissionLevel level)
        {
            Name = name;
            Level = level;
        }
    }
}
