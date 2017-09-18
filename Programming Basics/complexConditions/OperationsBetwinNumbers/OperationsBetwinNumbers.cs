using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsBetwinNumbers
{
    class OperationsBetwinNumbers
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            string oddOrEven;
            
                switch (operation)
                {
                    case '+':
                        if ((N1 + N2) % 2 == 0)
                        {
                            oddOrEven = "even";
                        }
                        else
                        {
                            oddOrEven = "odd";
                        }
                        Console.WriteLine($"{N1} {operation} {N2} = {N1 + N2} - {oddOrEven}");
                        break;
                    case '-':
                        if ((N1 - N2) % 2 == 0)
                        {
                            oddOrEven = "even";
                        }
                        else
                        {
                            oddOrEven = "odd";
                        }
                        Console.WriteLine($"{N1} {operation} {N2} = {N1 - N2} - {oddOrEven}");
                        break;
                    case '*':
                        if ((N1 * N2) % 2 == 0)
                        {
                            oddOrEven = "even";
                        }
                        else
                        {
                            oddOrEven = "odd";
                        }
                        Console.WriteLine($"{N1} {operation} {N2} = {N1 * N2} - {oddOrEven}");
                        break;
                    case '/':
                        if (N2 == 0)
                        {
                            Console.WriteLine($"Cannot divide {N1} by zero");
                        }
                        else
                        {
                            Console.WriteLine($"{N1} {operation} {N2} = {N1 / N2:f2}");
                        }
                        break;
                    case '%':
                        if (N2==0)
                        {
                            Console.WriteLine($"Cannot divide {N1} by zero");
                        }
                        else
                        {
                           Console.WriteLine($"{N1} {operation} {N2} = {N1 % N2}"); 
                        }
                        break;
                }
        }
    }
}
