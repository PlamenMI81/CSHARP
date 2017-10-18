using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Student[] students = new Student[lines];
            for (int i = 0; i < lines; i++)
            {
                students[i] = ReadStudent(Console.ReadLine());
            }

            foreach (Student student in students
                .Where(x => x.AverageGrade >= 5.00)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }

        private static Student ReadStudent(string readLine)
        {
            string[] inputLine = readLine.Split();
            List<double> grades = new List<double>();
            foreach (string s in inputLine.Skip(1))
            {
                grades.Add(Double.Parse(s));
            }
            return new Student {Name = inputLine[0], Grades = grades};
        }

        class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }
            public double AverageGrade => Grades.Average();
        }
    }
}
