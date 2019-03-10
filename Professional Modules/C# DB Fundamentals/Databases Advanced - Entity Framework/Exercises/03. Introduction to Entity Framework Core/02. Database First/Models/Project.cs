using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftUni.Models
{
    //[Table("Projects")]
    public class Project
    {
        public Project()
        {
            EmployeesProjects = new HashSet<EmployeeProject>();
        }

        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<EmployeeProject> EmployeesProjects { get; set; }
    }
}
