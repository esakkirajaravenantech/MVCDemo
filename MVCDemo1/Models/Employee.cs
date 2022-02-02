using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo1.Models
{
     [Table("tblEmployee")]
    public class Employee
    {
        [Key]
        public int EmployeID { get; set; }

        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        
        public int DepartmentId { get; set; }

    }

    

}