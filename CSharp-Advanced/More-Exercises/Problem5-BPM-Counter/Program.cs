using System;

namespace Problem5_BPM_Counter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double BPM = double.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());

            double bars = numberOfBeats / 4.0;
            double lenght = numberOfBeats / BPM * 60;


            int min = (int) lenght / 60;
            int sec = (int) lenght % 60;

            Console.WriteLine($"{Math.Round(bars, 1)} bars - {min}m {sec}s");
        }
    }
}