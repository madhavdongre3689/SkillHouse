using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationApp
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime DOB { get; set; }

        public Department Dept { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }
}
