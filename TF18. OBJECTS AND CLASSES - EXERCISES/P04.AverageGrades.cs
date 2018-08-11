using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < input; i++)
            {
                var studentData = Console.ReadLine()
                    .Split()
                    .ToList();

                Student student = GetStudentData(studentData);

                if (student.AverageGrade >= 5.00)
                {
                    students.Add(student);
                }
            }

            students.OrderBy(x => x.Name).ThenByDescending(av => av.AverageGrade).ToList()
                .ForEach(s => Console.WriteLine($"{s.Name} -> {s.AverageGrade:f2}"));

        }

        public static Student GetStudentData(List<string> studentData)
        {
            return new Student
            {
                Name = studentData[0],
                Grade = studentData.Skip(1).Select(double.Parse).ToList()
            };
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grade { get; set; }
        public double AverageGrade => Grade.Average();
    }
}
