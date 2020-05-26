using System.Collections.Generic;

namespace CSLabWork1C
{
    class MagazineCollection
    {
        public string CollectionName { get; set; }
        
        private List<Magazine> Magazines = new List<Magazine>();

        public MagazineCollection(string collectionName)
        {
            CollectionName = collectionName;
        }

        public void AddDefaults()
        {
            for (var i = 0; i < 3; i++)
            {
                Magazine magazine = new Magazine();
                Magazines.Add(magazine);
                MagazineAdded(magazine, new MagazineListHandlerEventArgs(
                    CollectionName, "Элемент добавлен в конец списка",
                    Magazines.Count - 1));
            }
        }

        public void AddMagazines(params Magazine[] magazines)
        {
            foreach (var magazine in magazines)
            {
                Magazines.Add(magazine);
                MagazineAdded(magazine, new MagazineListHandlerEventArgs(
                    CollectionName, "Элемент добавлен в конец списка",
                    Magazines.Count - 1));
            }
        }
        
        public bool Replace(int j, Magazine mg)
        {
            if (Magazines.Count > j)
            {
                Magazines[j] = mg;
                MagazineReplaced(mg, new MagazineListHandlerEventArgs(
                    CollectionName, "Присвоено новое значение элементу",
                    j));
                return true;
            }

            return false;
        }
        
        public Magazine this[int index]
        {
            get => Magazines[index];
            set
            {
                Magazines[index] = value;
                MagazineReplaced(value, new MagazineListHandlerEventArgs(
                    CollectionName, "Присвоено новое значение элементу",
                    index));
            }
        }
        
        public delegate void MagazineListHandler(object source, MagazineListHandlerEventArgs args);
        
        public event MagazineListHandler MagazineAdded;
        public event MagazineListHandler MagazineReplaced;
    }
}