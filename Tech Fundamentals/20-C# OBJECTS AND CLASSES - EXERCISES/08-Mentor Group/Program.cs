using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08_Mentor_Group
{
    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Date { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();
            List<DateTime> dates = new List<DateTime>();
            string nameUser = "";
            while (input != "end of dates")
            {
                string[] userAndDate = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                nameUser = userAndDate[0];
                foreach (var date in userAndDate.Skip(1))
                {
                    dates.Add(DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }

                input = Console.ReadLine();
            }


            student.Name = nameUser;
            student.Date = dates;

            string inputComments = Console.ReadLine();
            List<string> comments = new List<string>();
            while (input != "end of comments")
            {
                string[] userAndComment = inputComments.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string com in userAndComment.Skip(1))
                {
                    comments.Add(com);
                }
                if (student.Name.Equals(userAndComment[0]))
                {
                    student.Comments = comments;
                }

                input = Console.ReadLine();
            }
        }


    }
}
