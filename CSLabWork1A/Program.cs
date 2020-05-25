using System;

namespace CSLabWork1A
{
    class Program
    {
        public static void Main(string[] args)
        {
            ResearchTeamCollection collection1 = new ResearchTeamCollection("Команда 1");
            ResearchTeamCollection collection2 = new ResearchTeamCollection("Команда 2");

            TeamsJournal journal1 = new TeamsJournal();
            TeamsJournal journal2 = new TeamsJournal();

            collection1.ResearchTeamAdded += journal1.TeamEventHandler;
            collection1.ResearchTeamInserted += journal1.TeamEventHandler;

            collection1.ResearchTeamAdded += journal2.TeamEventHandler;
            collection1.ResearchTeamInserted += journal2.TeamEventHandler;

            collection2.ResearchTeamAdded += journal2.TeamEventHandler;
            collection2.ResearchTeamInserted += journal2.TeamEventHandler;

            collection1.AddDefaults();
            collection2.AddDefaults();

            collection1.AddResearchTeams(new ResearchTeam());

            collection2.InsertAt(1, new ResearchTeam());
            collection2.InsertAt(6, new ResearchTeam());

            Console.WriteLine(journal1.ToString());
            Console.WriteLine();
            Console.WriteLine(journal2.ToString());
            Console.ReadLine();
        }
    }
}