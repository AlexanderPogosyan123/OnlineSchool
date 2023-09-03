using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool
{
    public class School
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
                Console.WriteLine($"{"Индекс",-8}{"Имя",-12} {"Фамилия",-12}{"Возраст",-10}");
                for (int i = 0; i < Students.Count; i++)
                {
                    Console.WriteLine(new String('-', 40));
                    Console.WriteLine($"{(i+1)+"",-8}{Students[i].Name,-12}{Students[i].Sername,-12}{Students[i].Age,-10}");
                }

            }
        }
        public void AddNewStudent()
        {
            Console.WriteLine("Введите имя ученика: ");
            string name = Console.ReadLine();
            Program.CheckFormatInput(ref name);
            Console.WriteLine("Введите фамилию ученика: ");
            string sername = Console.ReadLine();
            Program.CheckFormatInput(ref sername);
            Console.WriteLine("Введите возраст ученика: ");
            int age;
            while (true)
            {

                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка,введите число: ");
                    Console.WriteLine();
                }
            }
            Student student = new Student(name,sername,age);
            Students.Add(student);
        }
        public void DeleteStudentFromSchool()
        {
            Console.WriteLine("Выберите под каким номером отчислить студента: ");
            int index = 0;
            while (true)
            {

                try
                {
                    index = Convert.ToInt32(Console.ReadLine());
                    if (index > Students.Count || index < 1)
                    {
                        Console.WriteLine("Неверный формат ввода ,введите номер из списка:");
                    }
                    else
                    {
                        break;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine("Неверный формат ввода ,введите номер из списка:");
                }
               
            }
            Console.WriteLine($"Студент {Students[index-1].Name} отчислен");
            Students.RemoveAt(index-1);
        }
        public void Exit()
        {
            System.Environment.Exit(0);
        }

    }
}
