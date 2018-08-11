using System;
using System.Collections.Generic;
using System.Linq;

namespace P09.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> clubs = CreateClubs();

            List<Team> invalidClubs = clubs.Where(x => x.TeamMembers.Count == 0).ToList();
            List<Team> validClubs = clubs.Where(x => x.TeamMembers.Count > 0).ToList();

            PrintValidClubs(validClubs);
            PrintInvalidClubs(invalidClubs);
        }

        public static void PrintInvalidClubs(List<Team> invalidClubs)
        {
            Console.WriteLine($"Teams to disband:");

            foreach (var team in invalidClubs.OrderBy(x => x.TeamName))
            {
                Console.WriteLine(team.TeamName);
            }
        }

        public static void PrintValidClubs(List<Team> validClubs)
        {
            foreach (var team in validClubs.OrderByDescending(x => x.TeamMembers.Count).ThenBy(y => y.TeamName))
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.CreatorName}");

                foreach (var member in team.TeamMembers.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }

        public static List<Team> CreateClubs()
        {
            int numOfTeams = int.Parse(Console.ReadLine());
            List<Team> clubs = new List<Team>();

            for (int i = 0; i < numOfTeams; i++)
            {
                string[] teamData = Console.ReadLine()
                    .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string teamCreator = teamData[0];
                string teamName = teamData[1];
                bool isTeamCreated = false;
                bool isCreatorExisted = false;

                for (int j = 0; j < clubs.Count; j++)
                {
                    if (clubs[j].TeamName == teamName)
                    {
                        Console.WriteLine($"Team {teamName} was already created!");
                        isTeamCreated = true;
                        break;
                    }
                }
                if (!isTeamCreated)
                {
                    for (int j = 0; j < clubs.Count; j++)
                    {
                        if (clubs[j].CreatorName == teamCreator)
                        {
                            Console.WriteLine($"{teamCreator} cannot create another team!");
                            isCreatorExisted = true;
                            break;
                        }
                    }
                }

                if (!isTeamCreated && !isCreatorExisted)
                {
                    Team currentTeam = new Team()
                    {
                        TeamName = teamName,
                        CreatorName = teamCreator,
                        TeamMembers = new List<string>()
                    };

                    clubs.Add(currentTeam);
                    Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
                }
            }

            string membersToJoin = Console.ReadLine();

            while (membersToJoin != "end of assignment")
            {
                string[] memberData = membersToJoin
                    .Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string memberName = memberData[0];
                string teamToJoin = memberData[1];
                bool isTeamExisting = false;
                bool isMemberExisting = false;

                for (int i = 0; i < clubs.Count; i++)
                {
                    if (clubs[i].TeamName == teamToJoin)
                    {
                        isTeamExisting = true;
                    }
                }

                if (!isTeamExisting)
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    membersToJoin = Console.ReadLine();
                    continue;
                }
                else
                {
                    for (int i = 0; i < clubs.Count; i++)
                    {
                        if (clubs[i].TeamMembers.Contains(memberName) || clubs[i].CreatorName == memberName)
                        {
                            isMemberExisting = true;
                        }
                    }
                }

                if (isMemberExisting)
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamToJoin}!");
                }
                else
                {
                    for (int i = 0; i < clubs.Count; i++)
                    {
                        if (clubs[i].TeamName == teamToJoin)
                        {
                            clubs[i].TeamMembers.Add(memberName);
                        }
                    }
                }

                membersToJoin = Console.ReadLine();
            }

            return clubs;
        }
    }

    public class Team
    {
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> TeamMembers { get; set; }
    }
}
