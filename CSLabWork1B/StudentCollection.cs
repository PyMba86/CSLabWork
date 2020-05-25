using System.Collections.Generic;

namespace CSLabWork1B
{
    class StudentCollection
    {
        public string CollectionName { get; set; }

        private List<Student> Students = new List<Student>();

        public StudentCollection(string collectionName)
        {
            CollectionName = collectionName;
        }

        public void AddDefaults()
        {
            for (var i = 0; i < 3; i++)
            {
                Student student = new Student("Студент " + i);
                Students.Add(student);
                StudentsCountChanged(student, new StudentListHandlerEventArgs(
                    CollectionName, "Студент добавлен в список",
                    student));
            }
        }

        public void AddStudents(params Student[] students)
        {
            foreach (var student in students)
            {
                Students.Add(student);
                StudentsCountChanged(student, new StudentListHandlerEventArgs(
                    CollectionName, "Студент добавлен в список",
                    student));
            }
        }

        public bool Remove(int j)
        {
            if (Students.Count > j)
            {
                Student student = Students[j];
                Students.Remove(student);
                StudentsCountChanged(student, new StudentListHandlerEventArgs(
                    CollectionName, "Студент удален из списка",
                    student));
                return true;
            }

            return false;
        }

        public Student this[int index]
        {
            get => Students[index];
            set
            {
                Students[index] = value;
                StudentReferenceChanged(value, new StudentListHandlerEventArgs(
                    CollectionName, "Элементу из списка присвоено новое значение",
                    value));
            }
        }

        public delegate void StudentListHandler(object source, StudentListHandlerEventArgs args);

        public event StudentListHandler StudentsCountChanged;
        public event StudentListHandler StudentReferenceChanged;
    }
}