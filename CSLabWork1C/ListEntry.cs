namespace CSLabWork1C
{
    public class ListEntry
    {
        public string CollectionName { get; set; }
        
        public string CollectionEvent { get; set; }

        public int NumberOfElement;

        public ListEntry( string collectionName, string collectionEvent, int numberOfElement)
        {
            NumberOfElement = numberOfElement;
            CollectionName = collectionName;
            CollectionEvent = collectionEvent;
        }

        public override string ToString()
        {
            return string.Format("Название коллекции: {0} \n" +
                                 "Событие: {1} \n" +
                                 "Номер элемента: {2} \n",
                CollectionName, CollectionEvent, NumberOfElement);
        }
    }
}