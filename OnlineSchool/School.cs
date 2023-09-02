﻿using System;
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
            Console.WriteLine("Введите фамилию ученика: ");
            string sername = Console.ReadLine();
            Console.WriteLine("Введите возраст ученика");
            int age = Convert.ToInt32(Console.ReadLine());
            Student student = new Student(name,sername,age);
            Students.Add(student);
        }

    }
}
