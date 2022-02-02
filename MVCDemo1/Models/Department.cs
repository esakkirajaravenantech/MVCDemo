using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo1.Models
{
    [Table("tblDepartment")]
    public class Department
    {
       
        [Key]
        public int ID { get; set; }

        public string DepartmentName { get; set; }

        public List<Employee> Employees { get; set; }
 
    }
}