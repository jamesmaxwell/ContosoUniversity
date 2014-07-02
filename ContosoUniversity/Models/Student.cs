using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "姓")]
        [StringLength(50, MinimumLength = 1)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "名")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "名字长度不能超过50")]
        [Column("FirstName")]
        public string FirstMidName { get; set; }

        [Display(Name = "注册日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "全名")]
        public string FullName
        {
            get { return FirstMidName + "," + LastName; }
        }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}