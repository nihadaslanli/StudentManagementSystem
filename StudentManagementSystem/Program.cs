

namespace StudentManagementSystem
{
    class Program
    {
        static DataContext dataContext = new DataContext();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nStudent Management System");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        dataContext.ViewStudents();
                        break;
                    case "3":
                        UpdateStudent();
                        break;
                    case "4":
                        DeleteStudent();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            Console.Write("Enter student age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter student grade: ");
            string grade = Console.ReadLine();

            dataContext.AddStudent(name, age, grade);
        }

        static void UpdateStudent()
        {
            Console.Write("Enter student ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter new name: ");
            string name = Console.ReadLine();
            Console.Write("Enter new age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter new grade: ");
            string grade = Console.ReadLine();

            dataContext.UpdateStudent(id, name, age, grade);
        }

        static void DeleteStudent()
        {
            Console.Write("Enter student ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            dataContext.DeleteStudent(id);
        }
    }
}
