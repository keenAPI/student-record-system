using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Record_System__LINQ_
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Marks { get; set; }

        public Student(string name, int age, double marks)
        {
            Name = name;
            Age = age;
            Marks = marks;
        }

        public override string ToString()
        {
            return $"{Name} | Age: {Age} | Mark: {Marks}";
        }
    }
}
