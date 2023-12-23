using CleanArch.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.ValueObject
{
    public class Name : CleanArch.Domain.Common.ValueObject
    {
        public string Value { get; }

        public Name(string value)
        {
            Value = value;
        }
    }
}

