using System;

namespace OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minOfExam = int.Parse(Console.ReadLine());
            int hourOfArival = int.Parse(Console.ReadLine());
            int minOfArival = int.Parse(Console.ReadLine());

            DateTime timeOfExam = new DateTime(1, 1, 1, hourOfExam, minOfExam, 0);
            DateTime timeOfArival = new DateTime(1, 1, 1, hourOfArival, minOfArival, 0);
            int compare = DateTime.Compare(timeOfArival, timeOfExam);
            if (compare > 0)
            {
                TimeSpan result = timeOfArival - timeOfExam;
                int resultHours = result.Hours;
                int resultMin = result.Minutes;
                if (resultHours == 0)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{resultMin} minutes after the start");
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{resultHours}:{resultMin:00} hours after the start");
                }
            }
            else if (compare <= 0)
            {
                TimeSpan result = timeOfExam - timeOfArival;
                int resultHours = result.Hours;
                int resultMin = result.Minutes;

                if (resultHours == 0 && resultMin <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{resultMin} minutes before the start");
                }
                else if (resultHours == 0 && resultMin > 30)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{resultMin} minutes before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{resultHours}:{resultMin:00} hours before the start");
                }
            }
        }
    }
}