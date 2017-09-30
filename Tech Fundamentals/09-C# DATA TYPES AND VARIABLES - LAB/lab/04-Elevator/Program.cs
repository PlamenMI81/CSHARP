using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople =int.Parse(Console.ReadLine());
            int capacity =int.Parse(Console.ReadLine());



            int cources =(int) Math.Ceiling((double)numOfPeople / capacity);
        }
    }
}
