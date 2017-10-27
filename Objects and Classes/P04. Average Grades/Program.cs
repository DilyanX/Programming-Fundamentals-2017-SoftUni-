using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Average_Grades
{
    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double Average => Grades.Average(); // средно аритметично от оценките на студентът

    }
    class Program
    {

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < input; i++)
            {
                Student student = new Student();
                string[] inputArgs = Console.ReadLine().Split(' ');

                student.Name = inputArgs[0];
                student.Grades = inputArgs.Skip(1).Select(double.Parse).ToList();// изпуска индекс 0(name) и чете останалата част от масива

                students.Add(student);
            }
            students
                 .Where(s => s.Average >= 5.00) // linq израз
                 .OrderBy(s => s.Name)
                 .ThenByDescending(s => s.Average)
                 .ToList()
                 .ForEach(s => Console.WriteLine($"{s.Name} -> {s.Average:F2}"));
        }
    }
}
