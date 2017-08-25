using System;
using System.Collections.Generic;
using System.Diagnostics;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("a) [C]urrency   - {0:C}", 1123.27);
// Integers only. The '5' sets the number of zeros to pad to the left.
        Console.WriteLine("b) [D]ecimal    - {0:D5}", 1123);
// Fixed decimal places including rounding.
        Console.WriteLine("c) [F]ixed      - {0:F3}", 1123.275);
// Scientific or decimal notation, whichever is shorter. Has a long set of rules in MSDN.
        Console.WriteLine("d) [G]eneral    - {0:G}", 1123.275);
// Similar to fixed, but includes ',' thousand seperator and is rounded to 2 dp by default.
        Console.WriteLine("e) [N]umber     - {0:N}", 1123.275);
// Percentage to 2 dp. So 0.99998 is 100%. The number is multiplied by 100 in order to be presented as a percentage
        Console.WriteLine("f) [P]ercent    - {0:P}", 0.2345);
// This shows the percentage but as a whole number, rounded. The number is multiplied by 100 in order to be presented as a percentage
        Console.WriteLine("g) [P]ercent    - {0:#%} ", 0.915);
        
        Console.WriteLine("h) [R]ound trip  -  {0:R}", 0.9998);  // Allows you to parse the resulting string using Single.Parse() or Double.Parse()
        Console.WriteLine("i) he[X]adecimal - 0x{0:X}", 255); // Integers only
        Console.WriteLine("j) [E]xpontial   - {0:E}", 10000000);
    }
}
