using System.Collections.Generic;

namespace CSLabWork1A
{
    class ResearchTeamCollection
    {
        public string CollectionName { get; set; }

        private List<ResearchTeam> SomeResearchTeams = new List<ResearchTeam>();

        public ResearchTeamCollection(string collectionName)
        {
            CollectionName = collectionName;
        }

        public void AddDefaults()
        {
            for (var i = 0; i < 3; i++)
            {
                ResearchTeam team = new ResearchTeam();
                SomeResearchTeams.Add(team);
                ResearchTeamAdded(team, new TeamListEventArgs(
                    CollectionName, "Элемент добавлен в конец списка",
                    SomeResearchTeams.Count - 1));
            }
        }

        public void AddResearchTeams(params ResearchTeam[] additionalTeams)
        {
            foreach (var team in additionalTeams)
            {
                SomeResearchTeams.Add(team);
                ResearchTeamAdded(team, new TeamListEventArgs(
                    CollectionName, "Элемент добавлен в конец списка",
                    SomeResearchTeams.Count - 1));
            }
        }

        public void InsertAt(int j, ResearchTeam rt)
        {
            if (SomeResearchTeams.Count < j)
            {
                SomeResearchTeams.Add(rt);
                ResearchTeamAdded(rt, new TeamListEventArgs(
                    CollectionName, "Элемент добавлен в конец списка",
                    SomeResearchTeams.Count - 1));
            }
            else
            {
                for (var i = 0; i < SomeResearchTeams.Count; i++)
                {
                    if (i - 1 == j)
                    {
                        SomeResearchTeams.Insert(i, rt);
                        ResearchTeamInserted(SomeResearchTeams[i],
                            new TeamListEventArgs(CollectionName,
                                "Элемент добавлен в список", j));
                    }
                }
            }
        }

        public delegate void TeamListHandler(object source, TeamListEventArgs args);

        public event TeamListHandler ResearchTeamAdded;
        public event TeamListHandler ResearchTeamInserted;
    }
}