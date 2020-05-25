namespace CSLabWork1B
{
    public class JournalEntry
    {
        public string CollectionName { get; set; }
        
        public string CollectionEvent { get; set; }

        public string Student;

        public JournalEntry(string collectionName, string collectionEvent, string student)
        {
            Student = student;
            CollectionName = collectionName;
            CollectionEvent = collectionEvent;
        }

        public override string ToString()
        {
            return string.Format("Название коллекции: {0} \n" +
                                 "Событие: {1} \n" +
                                 "Студент: {2} \n",
                CollectionName, CollectionEvent, Student);
        }
    }
}