using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Common
{
    public abstract class BaseDomainEntity
    {
        public BaseDomainEntity()
        {
            DateTime CreatedDate = DateTime.Now;
            DateTime LastModifiedDate = DateTime.Now;   



        }
        public  int Id { get;  set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public string LastModifiedBy { get; set;}
        public DateTime LastModifiedDate { get; set; }






    }
}
