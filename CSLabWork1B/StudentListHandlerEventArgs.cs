using System;

namespace CSLabWork1B
{
    class StudentListHandlerEventArgs : EventArgs
    {
        public string CollectionName { get; set; }
        public string ChangeType { get; set; }
        public Student ChangeItem { get; set; }

        public StudentListHandlerEventArgs(string collectionName, string changeType, Student changeItem)
        {
            CollectionName = collectionName;
            ChangeType = changeType;
            ChangeItem = changeItem;
        }

        public override string ToString()
        {
            return string.Format("Название коллекции: {0} \n" +
                                 "Тип изменения: {1} \n" +
                                 "Студент: {2} \n",
                CollectionName, ChangeType, ChangeItem);
        }
    }
}