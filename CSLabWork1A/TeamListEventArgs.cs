using System;

namespace CSLabWork1A
{
    class TeamListEventArgs : EventArgs
    {
        public string CollectionName { get; set; }
        public string ChangeType { get; set; }
        public int NumberOfChangeItem { get; set; }

        public TeamListEventArgs(string collectionName, string changeType, int numberOfChangeItem)
        {
            CollectionName = collectionName;
            ChangeType = changeType;
            NumberOfChangeItem = numberOfChangeItem;
        }

        public override string ToString()
        {
            return string.Format("Название коллекции: {0} \n" +
                                 "Тип изменения: {1} \n" +
                                 "Номер элемента: {2} \n",
                CollectionName, ChangeType, NumberOfChangeItem.ToString());
        }
    }
}