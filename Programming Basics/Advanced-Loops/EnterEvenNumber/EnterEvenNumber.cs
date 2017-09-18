using System;

namespace EnterEvenNumber
{
    class EnterEvenNumber
    {
        static void Main(string[] args)
        {
            int n=0;
            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    continue;
                }
                if (n % 2 == 0)
                {
                    break;
                }
                Console.WriteLine("Number is not even.");
            }
            Console.WriteLine("Even number entered: {0}", n);
        }
    }
}
