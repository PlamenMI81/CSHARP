using System;

namespace _08_Employee_Data
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            ulong personalID = ulong.Parse(Console.ReadLine());
            uint uniqueEmploeeID = uint.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {firstName}\r\n" +
                              $"Last name: {lastName}\r\n" +
                              $"Age: {age}\r\n" +
                              $"Gender: {gender}\r\n" +
                              $"Personal ID: {personalID}\r\n" +
                              $"Unique Employee number: {uniqueEmploeeID}");
        }
    }
}