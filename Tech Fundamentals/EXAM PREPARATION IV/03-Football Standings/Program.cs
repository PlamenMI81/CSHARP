using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_Football_Standings
{
    class Program
    {
        static void Main()
        {
            string key = Regex.Escape(Console.ReadLine());
            var encriptedLine = Console.ReadLine().Split();
            var patternTeam = $@"(?<={key})(\w+)(?={key})";
            var regex = new Regex(patternTeam);
            Dictionary<string, int> standingTable = new Dictionary<string, int>();
            Dictionary<string, int> goalsTable = new Dictionary<string, int>();
            while (encriptedLine[0] != "final")
            {
                DecryptInputFillResults(encriptedLine, regex, standingTable, goalsTable);

                encriptedLine = Console.ReadLine().Split();
            }
            PrintStats(standingTable,goalsTable);
        }

        private static void PrintStats(Dictionary<string, int> standingTable, Dictionary<string, int> goalsTable)
        {
            var sortedStanding = standingTable.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            Console.WriteLine("League standings:");
            var order = 1;
            foreach (var kvp in sortedStanding)
            {
                Console.WriteLine($"{order}. {kvp.Key} {kvp.Value}");
                order += 1;
            }
            Console.WriteLine("Top 3 scored goals:");
            var sortedGoals = goalsTable.OrderByDescending(x => x.Value).ThenBy(x=>x.Key).Take(3);
            foreach (var kvp in sortedGoals)
            {
                Console.WriteLine($"- {kvp.Key} -> {kvp.Value}");
            }

        }

        private static void DecryptInputFillResults(string[] encriptedLine, Regex regex, Dictionary<string, int> standingTable, Dictionary<string, int> goalsTable)
        {
            var decriptedTeamA = regex.Match(encriptedLine[0]).ToString();
            string teamA = new string(decriptedTeamA.ToCharArray().Reverse().ToArray()).ToUpper();
            var decriptedTeamB = regex.Match(encriptedLine[1]).ToString();
            string teamB = new string(decriptedTeamB.ToCharArray().Reverse().ToArray()).ToUpper();
            var score = encriptedLine[2].Split(':');
            var scoreTeamA = int.Parse(score[0]);
            var scoreTeamB = int.Parse(score[1]);
            var pointsA = 0;
            var pointsB = 0;
            if (scoreTeamA > scoreTeamB)
            {
                pointsA = 3;
                pointsB = 0;
                FillStandingTable(standingTable, teamA, pointsA);
                FillStandingTable(standingTable, teamB, pointsB);
            }
            else if (scoreTeamA < scoreTeamB)
            {
                pointsA = 0;
                pointsB = 3;
                FillStandingTable(standingTable, teamA, pointsA);
                FillStandingTable(standingTable, teamB, pointsB);
            }
            else
            {
                pointsA = 1;
                pointsB = 1;
                FillStandingTable(standingTable, teamA, pointsA);
                FillStandingTable(standingTable, teamB, pointsB);
            }
            FillGoalsTable(goalsTable,teamA,scoreTeamA);
            FillGoalsTable(goalsTable,teamB,scoreTeamB);
        }

        private static void FillGoalsTable(Dictionary<string, int> goalsTable, string team, int scoreTeam)
        {
            if (!goalsTable.ContainsKey(team))
            {
                goalsTable.Add(team,scoreTeam);
            }
            else
            {
                goalsTable[team] += scoreTeam;
            }
        }

        private static void FillStandingTable(Dictionary<string, int> standingTable, string team, int points)
        {
            if (!standingTable.ContainsKey(team))
            {
                standingTable.Add(team, points);
            }
            else
            {
                standingTable[team] += points;
            }
        }
    }
}

