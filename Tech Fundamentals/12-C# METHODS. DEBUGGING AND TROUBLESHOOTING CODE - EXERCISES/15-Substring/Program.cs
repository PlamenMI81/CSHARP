using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        sbyte count = sbyte.Parse(Console.ReadLine());

        const char search = 'p';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == search)
            {
                hasMatch = true;

                int endIndex = count+1;

                if (endIndex+i > text.Length-1)
                {
                    endIndex = text.Length-i;
                }

                string matchedString = text.Substring(i,endIndex);
                Console.WriteLine(matchedString);
                i += count;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}

