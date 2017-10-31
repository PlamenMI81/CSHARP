using System;
using System.Text.RegularExpressions;

namespace _01_Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"\s\w+([\.-]\w+)?@\w+[-]?\w+\.(\w+\.)?\w+";

            //Regex regex=new Regex(pattern);

            MatchCollection emails = Regex.Matches(input, pattern);
            foreach (Match email in emails)
            {
                var mail=email.Value.TrimStart(' ');
                if (!mail.StartsWith("_"))
                {
                    Console.WriteLine(mail);
                }
            }
        }
    }
}
