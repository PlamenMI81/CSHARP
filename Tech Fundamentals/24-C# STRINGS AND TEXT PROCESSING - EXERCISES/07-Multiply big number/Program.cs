using System;
using System.Text;

namespace _07_Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFirstLine = Console.ReadLine().TrimStart('0');
            var inputSecondLine = Console.ReadLine();
            var stringResult = "0";
            StringBuilder sb = new StringBuilder();
            var rem = 0;
            if (!inputSecondLine.Equals("0"))
            {
                stringResult = "";
                for (int i = inputFirstLine.Length - 1; i >= 0; i--)
                {
                    int currCharMult = (inputFirstLine[i] - 48) * (int.Parse(inputSecondLine.TrimStart('0'))) + rem;
                    if (currCharMult > 9 && i > 0)
                    {
                        rem = currCharMult / 10;
                        currCharMult = currCharMult % 10;
                    }
                    else
                    {
                        rem = 0;
                    }
                    sb.Insert(0, currCharMult);
                }
                stringResult = sb.ToString();
            }
            Console.WriteLine(stringResult);
        }
    }
}
