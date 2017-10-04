using System;

namespace _03_English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long lastDigit = Math.Abs(number % 10);
            NameLastDigit(lastDigit);
        }

        private static void NameLastDigit(long lastDigit)
        {
            string lastDigitToString = "";
            switch (lastDigit)
            {
                case 1: lastDigitToString = "one";break;
                case 2: lastDigitToString = "two";break;
                case 3: lastDigitToString = "three";break;
                case 4: lastDigitToString = "four";break;
                case 5: lastDigitToString = "five";break;
                case 6: lastDigitToString = "six"; break;
                case 7: lastDigitToString = "seven"; break;
                case 8: lastDigitToString = "eight"; break;
                case 9: lastDigitToString = "nine"; break;
                case 0: lastDigitToString = "zero"; break;
            }
            Console.WriteLine(lastDigitToString);
        }
    }
}
