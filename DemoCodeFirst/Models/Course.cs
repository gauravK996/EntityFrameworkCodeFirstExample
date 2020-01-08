using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DemoCodeFirst.Models
{
    public class Course
    {
        //[Key]
        public int Id { get; set; }
        public string CourseName { get; set; }
        public virtual ICollection<Student> Students { get;set; }
    }
}