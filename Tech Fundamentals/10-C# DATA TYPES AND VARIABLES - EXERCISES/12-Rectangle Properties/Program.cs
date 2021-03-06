﻿using System;

namespace _12_Rectangle_Properties
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = width * 2 + height * 2;
            double area = width * height;
            double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            Console.WriteLine($"{perimeter}\r\n{area}\r\n{diagonal}");
        }
    }
}