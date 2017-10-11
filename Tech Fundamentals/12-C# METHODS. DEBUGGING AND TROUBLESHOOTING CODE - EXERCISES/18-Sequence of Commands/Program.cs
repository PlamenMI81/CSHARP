using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        byte countOfNumbers = byte.Parse(Console.ReadLine());
        long[] numbers = new long[countOfNumbers];
        long[] tokens = Console.ReadLine().Split().Select(long.Parse).ToArray();
        for (int i = 0; i < countOfNumbers; i++)
        {
            numbers[i] = tokens[i];
        }
        string command = Console.ReadLine().ToLower();
        while (true)
        {
            if (command == "stop")
            {
                break;
            }
            //string line = Console.ReadLine().Trim();
            sbyte[] args = new sbyte[2];
            string[] stringParams = command.Split(ArgumentsDelimiter);
            if (command.Contains("add") || command.Contains("subtract") || command.Contains("multiply"))
            {
                args[0] = sbyte.Parse(stringParams[1]);
                args[1] = sbyte.Parse(stringParams[2]);
                PerformAction(ref numbers, stringParams[0], args);
                PrintArray(ref numbers);
            }
            else if (command.Contains("lshift") || command.Contains("rshift"))
            {
                PerformAction(ref numbers, stringParams[0], args);
                PrintArray(ref numbers);
            }

            // Console.WriteLine("\r\n");

            command = Console.ReadLine().ToLower();
        }
    }

    private static void PerformAction(ref long[] arr, string action, sbyte[] args)
    {
        //long[] array = arr.Clone() as long[];
        sbyte pos = args[0];
        sbyte value = args[1];

        switch (action)
        {
            case "multiply":
                arr[pos - 1] *= value;
                break;
            case "add":
                arr[pos - 1] += value;
                break;
            case "subtract":
                arr[pos - 1] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(ref arr);
                break;
            case "rshift":
                ArrayShiftRight(ref arr);
                break;
        }
        }

    private static void ArrayShiftRight(ref long[] array)
    {
        long temp = array[array.Length - 1];
        for (int i = array.Length - 1; i > 0; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = temp;
    }

    private static void ArrayShiftLeft(ref long[] array)
    {
        long temp = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = temp;
    }

    private static void PrintArray(ref long[] array)
    {
        Console.WriteLine(string.Join(" ", array));
    }
}
