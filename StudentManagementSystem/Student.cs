

namespace StudentManagementSystem
{
    internal partial class Program
    {
        class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Grade { get; set; }

        }
        static List<Student> students = new List<Student>();
        static int nextId = 1;

    }


}




