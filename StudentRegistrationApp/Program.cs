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
        public static ApplicationDbContext context = new ApplicationDbContext();
        public static void Main()
        {
            Console.WriteLine("Enter the options  1.Insert Data 2.Fetch Single Student 3) Fetch all students");

            int input = int.Parse(Console.ReadLine());
           
            switch(input)
            {
                case 1:InsertData();
                    break;
                case 2: Console.WriteLine("Enter Student's name");
                        string name=Console.ReadLine();
                        var student = GetStudent(name);
                        Console.WriteLine(student.Name);
                        break;
                case 3:
                    
  
                    var students = GetStudentList();
                    foreach(Student std in students)
                    {
                        Console.WriteLine(std.Name);
                    }
                    
                    break;
            }

            Console.Read();
        }

        public static void InsertData()
        {
            Student student = new Student();
            student.Name = "Madhav";
            student.Age = 30;
            //student.DOB = new DateTime(31, 12, 1990);
            student.Dept = new Department();
            student.Dept.Name = "CS";
            context.Students.Add(student);
            context.Departments.Add(student.Dept);
            context.SaveChanges();
        }

        public static Student GetStudent(string name)
        {
            var studentList=context.Students.ToList();
            var student = studentList.Where(a => a.Name == name).FirstOrDefault();

            return student;
        }

        public static List<Student> GetStudentList()
        {
            var studentList = context.Students.ToList();

            return studentList;
        }
    }

}