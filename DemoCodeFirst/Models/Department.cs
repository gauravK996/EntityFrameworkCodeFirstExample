using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DemoCodeFirst.Models
{
    public class Department
    {
        [Key]
        public int Deapartmentid { get; set; } 

        public string Deaparttment { get; set; }
        
        public virtual ICollection<Student> students { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}