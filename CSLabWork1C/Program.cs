using System;

namespace CSLabWork1C
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            MagazineCollection collection1 = new MagazineCollection("Магазин 1");
            MagazineCollection collection2 = new MagazineCollection("Магазин 2");

            Listener listener1 = new Listener();
            Listener listener2 = new Listener();

            collection1.MagazineAdded += listener1.MagazineEventHandler;
            collection1.MagazineReplaced += listener1.MagazineEventHandler;

            collection1.MagazineAdded += listener2.MagazineEventHandler;
            collection1.MagazineReplaced += listener2.MagazineEventHandler;

            collection2.MagazineAdded += listener2.MagazineEventHandler;
            collection2.MagazineReplaced += listener2.MagazineEventHandler;

            collection1.AddDefaults();
            collection2.AddDefaults();

            collection1.AddMagazines(new Magazine());

            collection1.Replace(0, new Magazine());
            collection2.Replace(2, new Magazine());
            
            collection2[1] = new Magazine();

            Console.WriteLine(listener1.ToString());
            Console.WriteLine();
            Console.WriteLine(listener2.ToString());
            Console.ReadLine();
        }
    }
}