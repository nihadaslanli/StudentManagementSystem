using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StudentManagementSystem
{
    internal class DataContext
    {

        private List<Student> students = new List<Student>();
        private int nextId = 1;

        public void AddStudent(string name, int age, string grade)
        {
            students.Add(new Student { ID = nextId++, Name = name, Age = age, Grade = grade });
            Console.WriteLine("Student added successfully!");
        }
        public void ViewStudents()
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
        public void UpdateStudent(int id, string name, int age, string grade)
        {
            Student student = students.Find(s => s.ID == id);
            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            student.Name = name;
            student.Age = age;
            student.Grade = grade;
            Console.WriteLine("Student updated successfully!");
        }
        public void DeleteStudent(int id)
        {
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

