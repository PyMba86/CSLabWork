using System.Collections.Generic;

namespace CSLabWork1A
{
    class ResearchTeamCollection
    {
        public string CollectionName { get; set; }

        private List<ResearchTeam> ResearchTeams = new List<ResearchTeam>();

        public ResearchTeamCollection(string collectionName)
        {
            CollectionName = collectionName;
        }

        public void AddDefaults()
        {
            for (var i = 0; i < 3; i++)
            {
                ResearchTeam team = new ResearchTeam();
                ResearchTeams.Add(team);
                ResearchTeamAdded(team, new TeamListEventArgs(
                    CollectionName, "Элемент добавлен в конец списка",
                    ResearchTeams.Count - 1));
            }
        }

        public void AddResearchTeams(params ResearchTeam[] additionalTeams)
        {
            foreach (var team in additionalTeams)
            {
                ResearchTeams.Add(team);
                ResearchTeamAdded(team, new TeamListEventArgs(
                    CollectionName, "Элемент добавлен в конец списка",
                    ResearchTeams.Count - 1));
            }
        }

        public void InsertAt(int j, ResearchTeam rt)
        {
            if (ResearchTeams.Count < j)
            {
                ResearchTeams.Add(rt);
                ResearchTeamAdded(rt, new TeamListEventArgs(
                    CollectionName, "Элемент добавлен в конец списка",
                    ResearchTeams.Count - 1));
            }
            else
            {
                for (var i = 0; i < ResearchTeams.Count; i++)
                {
                    if (i - 1 == j)
                    {
                        ResearchTeams.Insert(i, rt);
                        ResearchTeamInserted(ResearchTeams[i],
                            new TeamListEventArgs(CollectionName,
                                "Элемент добавлен в список", j));
                    }
                }
            }
        }
        
        public ResearchTeam this[int index] {
            get => ResearchTeams[index];
            set => ResearchTeams[index] = value;
        }

        public delegate void TeamListHandler(object source, TeamListEventArgs args);

        public event TeamListHandler ResearchTeamAdded;
        public event TeamListHandler ResearchTeamInserted;
    }
}