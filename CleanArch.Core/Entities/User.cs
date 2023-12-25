using CleanArch.Domain.Common;
using CleanArch.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public class User : BaseDomainEntity
    {
        public string Name { get; set; }

        [Required(ErrorMessage = "يرجى إدخال عنوان بريد إلكتروني.")]
        [EmailAddress(ErrorMessage = "البريد الإلكتروني غير صحيح.")]
        public string Email { get; set; }

        public Status Status { get; set; }
        public DateTime BirthDate { get;  set; }

        [Column("address")]
        [StringLength(50)]
        [Required(ErrorMessage = "يرجى إدخال عنوان صحيح.")]
        public string Address { get;  set; }
        [Required(ErrorMessage = "يرجى إدخال رقم هاتف صحيح.")]
        [Phone(ErrorMessage = "رقم الهاتف غير صحيح.")]
        public string Phone { get;  set; }

        [Required(ErrorMessage = "يرجى تحديد جنس المستخدم.")]
        public string Gender { get;  set; }

        [Required(ErrorMessage = "يرجى إدخال اسم مستخدم.")]
        public string Username { get;  set; }

        [Required(ErrorMessage = "يرجى إدخال كلمة مرور.")]
        [MinLength(8, ErrorMessage = "يجب أن تتألف كلمة المرور من الأقل 8 أحرف.")]
        public string Password { get;  set; }

        [Compare("Password", ErrorMessage = "كلمة المرور وتأكيد كلمة المرور غير متطابقين.")]
        public string ConfirmPassword { get;  set; }

        [Required(ErrorMessage = "يرجى تحديد حالة المستخدم.")]
        public bool Enabled { get;  set; }
        [Required(ErrorMessage = "يرجى تحديد حالة تفعيل المستخدم.")]
        [Display(Name = "Is Active")]
        public bool IsActive { get;  set; }
        public Group UserGroup { get; set; }
    }

}
