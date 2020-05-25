using System.Collections.Generic;

namespace CSLabWork1B
{
    class Journal
    {
        private List<JournalEntry> ListOfChanges = new List<JournalEntry>();

        public void StudentEventHandler(object o, StudentListHandlerEventArgs args)
        {
            ListOfChanges.Add(new JournalEntry(
                args.CollectionName, args.ChangeType,
                args.ChangeItem.ToString()));
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