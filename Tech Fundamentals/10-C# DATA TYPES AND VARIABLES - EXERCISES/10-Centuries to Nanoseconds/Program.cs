using System;
using System.Numerics;

namespace _10_Centuries_to_Nanoseconds
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Write program to enter an integer number of centuries and convert it to years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds.
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort) (centuries * 100);
            uint days = (uint) (years * 365.2422);
            uint hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            Console.WriteLine(
                $"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} " +
                $"seconds = {seconds}000 milliseconds = {seconds}000000 microseconds = {seconds}000000000 nanoseconds");
        }
    }
}