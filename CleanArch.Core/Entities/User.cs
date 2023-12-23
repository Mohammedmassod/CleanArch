using CleanArch.Domain.Common;
using CleanArch.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public UserStatus Status { get; set; }

        public UserGroup UserGroup { get; set; }
    }

}
