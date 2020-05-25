using System;

namespace CSLabWork1B
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StudentCollection collection1 = new StudentCollection("Отличники");
            StudentCollection collection2 = new StudentCollection("Должники");

            Journal journal1 = new Journal();
            Journal journal2 = new Journal();

            collection1.StudentsCountChanged += journal1.StudentEventHandler;
            collection1.StudentReferenceChanged += journal1.StudentEventHandler;

            collection1.StudentsCountChanged += journal2.StudentEventHandler;
            collection1.StudentReferenceChanged += journal2.StudentEventHandler;

            collection2.StudentsCountChanged += journal2.StudentEventHandler;
            collection2.StudentReferenceChanged += journal2.StudentEventHandler;

            collection1.AddDefaults();
            collection2.AddDefaults();

            collection1.AddStudents(new Student("Иванов Иван"));

            collection2.AddStudents(new Student("Сидоров Дима"));

            collection2.Remove(1);
            collection1.Remove(4);

            collection1.Remove(6);

            collection2[0] = new Student("Петров Денис");

            Console.WriteLine(journal1.ToString());
            Console.WriteLine();
            Console.WriteLine(journal2.ToString());
            Console.ReadLine();
        }
    }
}