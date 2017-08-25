using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starsqare
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            Console.WriteLine(new String('*',size));
            for (int i = 0; i < size-2; i++)
            {
                Console.Write('*');
                Console.Write(new String(' ', size-2));
                Console.WriteLine('*');
            }
            Console.WriteLine(new String('*', size));
            
        }
}
}
