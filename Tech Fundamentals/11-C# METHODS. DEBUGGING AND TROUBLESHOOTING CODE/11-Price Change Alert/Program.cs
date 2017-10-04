using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double firstPrice = double.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double nextPrice = double.Parse(Console.ReadLine());
            double diffrenceInPercent = FindPercent(firstPrice, nextPrice);
            bool isSignificantDifference = SignificantDiffrent(diffrenceInPercent, threshold);
            string message = FormatOutput(nextPrice, firstPrice, diffrenceInPercent, isSignificantDifference);
            Console.WriteLine(message);
            firstPrice = nextPrice;
        }
    }

    private static string FormatOutput(double nextPrice, double firstPrice, double diffrenceInPercent, bool isSignificantDifference)
    {
        string to = "";
        if (diffrenceInPercent == 0)
        {
            to = string.Format("NO CHANGE: {0}", nextPrice);
        }
        else if (!isSignificantDifference)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", firstPrice, nextPrice, diffrenceInPercent*100);
        }
        else if (isSignificantDifference && (diffrenceInPercent > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", firstPrice, nextPrice, diffrenceInPercent*100);
        }
        else if (isSignificantDifference && (diffrenceInPercent < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", firstPrice, nextPrice, diffrenceInPercent*100);
        return to;
    }
    private static bool SignificantDiffrent(double diffrenceInPercent, double threshold)
    {
        if (Math.Abs(diffrenceInPercent) >= threshold)
        {
            return true;
        }
        return false;
    }

    private static double FindPercent(double firstPrice, double nextPrice)
    {
        double percent = (nextPrice - firstPrice) / firstPrice;
        return percent;
    }
}
