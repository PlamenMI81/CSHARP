using System;

namespace _18_Different_Integers_Size
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string number = Console.ReadLine();
            try
            {
                long numLong = long.Parse(number);
                Console.WriteLine($"{number} can fit in:");
            }
            catch (Exception e)
            {
                
            }
            try
            {
                sbyte numSByte = sbyte.Parse(number);
                Console.WriteLine("* sbyte");
            }
            catch (Exception e)
            {
            }
            try
            {
                byte numByte = byte.Parse(number);
                Console.WriteLine("* byte");
            }
            catch (Exception e)
            {
            }
            try
            {
                short numShort = short.Parse(number);
                Console.WriteLine("* short");
            }
            catch (Exception e)
            {
            }
            try
            {
                ushort numUShort = ushort.Parse(number);
                Console.WriteLine("* ushort");
            }
            catch (Exception e)
            {
            }
            try
            {
                int numInt = int.Parse(number);
                Console.WriteLine("* int");
            }
            catch (Exception e)
            {
            }
            try
            {
                uint numUInt = uint.Parse(number);
                Console.WriteLine("* uint");
            }
            catch (Exception e)
            {
            }
            try
            {
                long numLong = long.Parse(number);
                Console.WriteLine("* long");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}