using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool
{
    internal class School
    {
        private string Name { get; }
        private List<Student> Students = new List<Student>();

        public School(string name)
        {
            Name = name;
        }
        public void PrintAllStudents()
        {
            if (Students.Count == 0)
            {
                Console.WriteLine($"В школе {Name} нету учеников");
            }
            else
            {
                Console.WriteLine($"{"Имя",-10} {"Фамилия",-10}{"Возраст",-10}");
                foreach (var student in Students)
                {
                    Console.WriteLine("{0,-10}{1,-10}{2,-10}", student.Name, student.Sername, student.Age);
                }

            }
        }
        public void AddNewStudent()
        {
            Console.WriteLine("Введите имя ученика: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию ученика: ");
            string sername = Console.ReadLine();
            Console.WriteLine("Введите возраст ученика");
            int age = Convert.ToInt32(Console.ReadLine());
            Student student = new Student(name,sername,age);
            Students.Add(student);
        }

    }
}
