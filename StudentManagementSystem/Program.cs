

namespace StudentManagementSystem
{
    internal partial class Program
    {
        static void Main(string[] args)
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
                        ViewStudents();
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

                students.Add(new Student { ID = nextId++, Name = name, Age = age, Grade = grade });
                Console.WriteLine("Student added successfully!");
            }

            static void ViewStudents()
            {
                if (students.Count == 0)
                {
                    Console.WriteLine("No students found.");
                    return;
                }

                foreach (var student in students)
                {
                    Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
                }
            }

            static void UpdateStudent()
            {
                Console.Write("Enter student ID to update: ");
                int id = int.Parse(Console.ReadLine());

                Student student = students.Find(s => s.ID == id);
                if (student == null)
                {
                    Console.WriteLine("Student not found.");
                    return;
                }

                Console.Write("Enter new name: ");
                student.Name = Console.ReadLine();
                Console.Write("Enter new age: ");
                student.Age = int.Parse(Console.ReadLine());
                Console.Write("Enter new grade: ");
                student.Grade = Console.ReadLine();

                Console.WriteLine("Student updated successfully!");
            }

            static void DeleteStudent()
            {
                Console.Write("Enter student ID to delete: ");
                int id = int.Parse(Console.ReadLine());

                Student student = students.Find(s => s.ID == id);
                if (student == null)
                {
                    Console.WriteLine("Student not found.");
                    return;
                }

                students.Remove(student);
                Console.WriteLine("Student deleted successfully!");
            }
        
    }
}






