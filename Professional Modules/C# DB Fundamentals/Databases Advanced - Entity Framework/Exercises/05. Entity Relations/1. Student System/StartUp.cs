using System;
using System.Net.Mime;
using P01_StudentSystem.Data;
using P01_StudentSystem.Data.Models;
using P01_StudentSystem.Enumerations;
using ContentType = P01_StudentSystem.Enumerations.ContentType;

namespace P01_StudentSystem 
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new StudentSystemContext())
            {
                dbContext.Database.EnsureDeleted();
                dbContext.Database.EnsureCreated();

                Seed(dbContext);
            }
        }

        static void Seed(StudentSystemContext dbContext)
        {
            var students = new[]
            {
                new Student
                {
                    Birthday = new DateTime(1995, 11, 3),
                    Name = "Georgi Ivanov",
                    PhoneNumber = "0888123456",
                    RegisteredOn = new DateTime(2015, 8, 7)
                },

                new Student
                {
                    Name = "Todor Petrov",
                    RegisteredOn = new DateTime(2016, 3, 5)
                },

                new Student
                {
                    Name = "Vasil Ivanov",
                    Birthday = new DateTime(1998, 1, 4),
                    RegisteredOn = new DateTime(2017, 12, 20)
                },

                new Student
                {
                    Name = "Mihail Todorov",
                    RegisteredOn = new DateTime(2017, 1, 7),
                    PhoneNumber = "0877445566"
                }
            };

            dbContext.Students.AddRange(students);

            var courses = new[]
            {
                new Course
                {
                    Name = "JS Fundamentals",
                    Description = "JS for beginners",
                    StartDate = new DateTime(2016, 9, 18),
                    EndDate = new DateTime(2016, 10, 20),
                    Price = 180.00m
                },

                new Course
                {
                    Name = "JS Advanced",
                    StartDate = new DateTime(2016, 10, 21),
                    EndDate = new DateTime(2016, 11, 19),
                    Price = 180.00m
                },

                new Course
                {
                    Name = "Js Applications",
                    StartDate = new DateTime(2016, 11, 20),
                    EndDate = new DateTime(2016, 12, 18),
                    Description = "JS Приложения",
                    Price = 200.00m
                }
            };

            dbContext.Courses.AddRange(courses);

            var resources = new[]
            {
                new Resource
                {
                    Name = "Intro",
                    Url = "softuni.bg/resources/0123456789",
                    ResourceType = ResourceType.Presentation,
                    Course = courses[0]
                },

                new Resource
                {
                    Name = "OOP Intro",
                    Url = "softuni.bg/resources/1245687",
                    ResourceType = ResourceType.Video,
                    Course = courses[1]
                },

                new Resource
                {
                    Name = "Objects",
                    Url = "softuni.bg/resources/556688",
                    ResourceType = ResourceType.Document,
                    Course = courses[1]
                }
            };

            dbContext.Resources.AddRange(resources);

            var homeworks = new[]
            {
                new Homework
                {
                     Content = "softuni.bg/homeworks/124578",
                     ContentType = ContentType.Zip,
                     SubmissionTime = new DateTime(2016, 2, 5, 12, 45, 55),
                     Course = courses[0],
                     Student = students[2]
                },

                new Homework
                {
                    Content = "softuni.bg/homeworks/225588",
                    ContentType = ContentType.Pdf,
                    SubmissionTime = new DateTime(2017, 5, 8, 14, 22, 36),
                    Course = courses[1],
                    Student = students[0]
                },

                new Homework
                {
                    Content = "softuni.bg/homeworks/44778855",
                    ContentType = ContentType.Application,
                    SubmissionTime = new DateTime(2017, 4, 6, 18, 22, 54),
                    Course = courses[1],
                    Student = students[2]
                }
            };

            dbContext.HomeworkSubmissions.AddRange(homeworks);

            var studentcourses = new[]
            {
                new StudentCourse
                {
                    Student = students[0],
                    Course = courses[1]
                },

                new StudentCourse
                {
                    Student = students[1],
                    Course = courses[2]
                },

                new StudentCourse
                {
                    Student = students[1],
                    Course = courses[1]
                }
            };

            dbContext.StudentCourses.AddRange(studentcourses);

            dbContext.SaveChanges();
        }
    }
}