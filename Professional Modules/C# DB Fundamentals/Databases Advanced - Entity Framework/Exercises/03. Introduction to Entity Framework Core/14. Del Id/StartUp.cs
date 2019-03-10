using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14._Delete_Project_by_Id
{
    class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            using (context)
            {
                Console.WriteLine(DeleteProjectById(context));
            }
        }

        public static string DeleteProjectById(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            const int ProjectToBeDeletedId = 2;

            Project projectToBeDeleted = context.Projects.Find(ProjectToBeDeletedId);

            List<EmployeeProject> employeeProjectsToBeDeleted = context
                .EmployeesProjects
                .Where(e => e.Project.ProjectId == ProjectToBeDeletedId)
                .ToList();

            context.EmployeesProjects.RemoveRange(employeeProjectsToBeDeleted);
            context.SaveChanges();

            context.Remove(projectToBeDeleted);
            context.SaveChanges();

            foreach (string projectName in context.Projects.Select(p => p.Name).Take(10))
            {
                Console.WriteLine(projectName);
            }

            return sb.ToString();
        }
    }
}