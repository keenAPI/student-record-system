using System.Net.WebSockets;

namespace Student_Record_System__LINQ_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Alice", 20, 85.5),
                new Student("Bob", 22, 78.2),
                new Student("Charlie", 21, 90.1),
                new Student("David", 23, 72.3),
                new Student("Emma", 19, 88.8)
            };

            //Display all students
            Console.WriteLine("All Students:");
            Console.WriteLine();
            students.ForEach(s => Console.WriteLine(s));

            //Filter students who scored above 80
            var highScores = students.Where(s => s.Marks > 80);
            Console.WriteLine("\nStudents Scoring Above 80:");
            Console.WriteLine();
            foreach (var student in highScores)
                Console.WriteLine(student);

            //Sort Students by Marks (Descending)
            var sortedByMarks = students.OrderByDescending(s => s.Marks);
            Console.WriteLine("\nStudents Sorted by Marks (Descending):");
            Console.WriteLine();
            foreach (var student in sortedByMarks)
                Console.WriteLine(student);

            //Find the Student with the Highest Marks
            var topStudent = students.OrderByDescending(s => s.Marks).FirstOrDefault();
            Console.WriteLine($"\nTop Student: {topStudent}");

            //Get the Average Marks of All Students
            var averageMarks = students.Average(s => s.Marks);
            Console.WriteLine($"\nAverage Marks: {averageMarks:F2}");

            //Group Students By Age
            var groupedByAge = students.GroupBy(s => s.Age);
            Console.WriteLine("\nStudents Grouped by Age:");
            foreach (var group in groupedByAge)
            {
                Console.WriteLine($"\nAge: {group.Key}");
                foreach (var student in group)
                    Console.WriteLine(student);
            }
           
        }
    }
}
