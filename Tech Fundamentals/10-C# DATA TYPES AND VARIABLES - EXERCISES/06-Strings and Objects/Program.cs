using System;

namespace _06_Strings_and_Objects
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object helloWorldObj = hello + " " + world;
            string helloWorldStr = (string) helloWorldObj;
            Console.WriteLine(helloWorldStr);
        }
    }
}