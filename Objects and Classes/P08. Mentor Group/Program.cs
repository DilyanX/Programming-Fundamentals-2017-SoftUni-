using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08.Mentor_Group
{
    public class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> DatesAttend { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> StudentsList = new List<Student>();
            Student Student = new Student();
            List<DateTime> Dates = new List<DateTime>();
            string input = Console.ReadLine().Trim();
            while (!(input == "end of dates"))
            {
                var arr = input.Split(' ').ToList();
                Student.Name = arr[0];
                if (arr.Count > 1)
                {
                    var dateStringAttend = arr[1].Split(',').ToList();

                    foreach (var item in dateStringAttend)
                    {
                        Dates.Add(DateTime.ParseExact(item, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                    Student.DatesAttend = Dates;
                }
                StudentsList.Add(Student);
                Dates = new List<DateTime>();
                Student = new Student();
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (!(input == "end of comments"))
            {
                List<string> arg = input.Split('-').ToList();
                var commentName = arg[0];
                var commentNew = arg[1];

                foreach (var studentt in StudentsList)
                {
                    if (studentt.Name == commentName)
                    {
                        if (studentt.Comments == null)
                        {
                            studentt.Comments = new List<string>();
                        }
                        
                        studentt.Comments.Add(commentNew);
                    }
                }
                input = Console.ReadLine();
            }
            List<Student> orderedByNameStudents = StudentsList.OrderBy(s => s.Name).ToList();
            foreach (var student in orderedByNameStudents)
            {

                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                List<string> listOfComments = student.Comments;
                if (listOfComments != null)
                {
                    foreach (var comment in listOfComments)
                    {
                        Console.WriteLine("- {0}", comment);
                    }
                }
                Console.WriteLine("Dates attended:");
                if (student.DatesAttend != null)
                {
                    List<DateTime> dati = student.DatesAttend.OrderBy(s => s.Date).ToList();
                    if (dati != null)
                    {
                        foreach (var data in dati)
                        {
                            Console.WriteLine("-- " + data.ToString("dd/MM/yyyy"));
                        }
                    }
                }
            }
        }
    }
}

