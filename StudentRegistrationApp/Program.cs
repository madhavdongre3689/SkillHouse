// See https://aka.ms/new-console-template for more information
using StudentRegistrationApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentRegistrationApp.DbContext;
namespace StudentRegistrationApp
{

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello, World!");
            Student student = new Student();
            student.Name = "Madhav";
            ApplicationDbContext context = new ApplicationDbContext();
            context.Students.Add(student);
            Console.Read();
        }
    }

}