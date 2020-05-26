using System.Collections.Generic;

namespace CSLabWork1C
{
    class Listener
    {
        private List<ListEntry> ListOfChanges = new List<ListEntry>();

        public void MagazineEventHandler(object o, MagazineListHandlerEventArgs args)
        {
            ListOfChanges.Add(new ListEntry(
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