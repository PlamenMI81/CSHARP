using System;

namespace VowelsSum
{
    class VowelsSum
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'a':
                        sum = sum + 1; break;
                    case 'e':
                        sum = sum + 2; break;
                    case 'i':
                        sum = sum + 3; break;
                    case 'o':
                        sum = sum + 4; break;
                    case 'u':
                        sum = sum + 5; break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
