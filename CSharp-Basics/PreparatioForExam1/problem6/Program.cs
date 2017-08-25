using System;

namespace problem6
{ //sum or product
    class Program
    {
        static void Main()
        {
            int controlNum = int.Parse(Console.ReadLine());
            bool isPrint = false;
            for (int i = 1; i <= 30; i++)
            {
                for (int j = 1; j <= 30; j++)
                {
                    for (int k = 1; k <= 30; k++)
                    {
                        int product = i * j * k;
                        int sum = i + j + k;
                        if (sum == controlNum)
                        {
                            if (i < j && j < k)
                            {
                                Console.WriteLine($"{i} + {j} + {k} = {sum}");
                                isPrint = true;
                            }
                        }
                        if (product == controlNum)
                        {
                            if (i > j && j > k)
                            {
                                Console.WriteLine($"{i} * {j} * {k} = {product}");
                                isPrint = true;
                            }
                        }
                    }
                }
            }
            if (isPrint == false)
            {
                Console.WriteLine("No!");
            }
        }
    }
}