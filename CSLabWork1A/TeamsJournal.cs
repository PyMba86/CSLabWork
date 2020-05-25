using System.Collections.Generic;

namespace CSLabWork1A
{
    class TeamsJournal
    {
        private List<TeamsJournalEntry> ListOfChanges = new List<TeamsJournalEntry>();

        public void TeamEventHandler(object o, TeamListEventArgs args)
        {
            ListOfChanges.Add(new TeamsJournalEntry(
                args.CollectionName, args.ChangeType, args.NumberOfChangeItem));
        }

        public override string ToString()
        {
            string str = "";
            foreach (var change in ListOfChanges)
            {
                str += change + "\n";
            }

            return str;
        }
    }
}