using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoCodeFirst.Models
{
    //[Table("ssssssss")]
    public class Student
    {
        //[Key]
        public int Id { get; set; }
        // [Column("Student_Name"/*,TypeName =string,Order =2*/]
        [Required]
        [MaxLength(20)]
        //[StringLength(299)]
        //[Timestamp]
        //[ConcurrencyCheck]
        public string Name { get; set; }
        //[NotMapped()] use   notmapped ef does not create column table by defaults all column created 
        // or if any properties does not have getter or setter properties it is not crate colum
        public DateTime? Dob { get; set; }
        public int Deapartmentid { get; set;}
        [ForeignKey("Deapartmentid")]
        public virtual  Department Department { get; set; }
        public int courseid { get; set; }
        [ForeignKey("courseid")]
        
        public virtual Course Course { get; set; }
        
        //public int Studentaddresid { get; set; }
        //[ForeignKey("Studentaddresid")]
       public virtual Studentaddress Studentaddress { get; set;}
    }
}