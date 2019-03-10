using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftUni.Models
{
    //[Table("EmployeesProjects")]
    public class EmployeeProject
    {
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }

        public Employee Employee { get; set; }
        public Project Project { get; set; }

        internal static object First()
        {
            throw new NotImplementedException();
        }
    }
}
