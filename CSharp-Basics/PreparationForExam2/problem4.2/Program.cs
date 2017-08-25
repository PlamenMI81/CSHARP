using System;

namespace problem4._2
{ //Grades
    internal class Program
    {
        private static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int count5to6 = 0;
            int count4to5 = 0;
            int count3to4 = 0;
            int count2to3 = 0;
            double sredenUspeh = 0;
            for (int i = 1; i <= students; i++)
            {
                double exam = double.Parse(Console.ReadLine());
                if (exam >= 5.00)
                    count5to6++;
                else if (exam >= 4.00 && exam <= 4.99)
                    count4to5++;
                else if (exam >= 3.00 && exam <= 3.99)
                    count3to4++;
                else
                    count2to3++;
                sredenUspeh = sredenUspeh + exam;
            }
            sredenUspeh = sredenUspeh / students;
            Console.WriteLine($"Top students: {(double) count5to6 / students * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(double) count4to5 / students * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(double) count3to4 / students * 100:f2}%");
            Console.WriteLine($"Fail: {(double) count2to3 / students * 100:f2}%");
            Console.WriteLine($"Average: {sredenUspeh:f2}");
        }
    }
}