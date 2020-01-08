using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoCodeFirst.Models
{
    public class Studentaddress
    {   
        
        //[Key, ForeignKey("Student")]
        //[Key]
        public int StudentaddressId { get; set; }  
        public string Address { get; set; }
        public virtual Student Student { get; set; } 

    }
}