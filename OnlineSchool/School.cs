using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool
{
    internal class School
    {
        public string Name { get; }
        private List<Student> Students = new List<Student>();

        public School(string name)
        {
            Name = name;
        }
        public void PrintAllStudents()
        {
            Console.WriteLine();
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
            Console.WriteLine();
            Console.WriteLine("Введите имя ученика: ");
            string name = Console.ReadLine();
            CheckAndCorrectFormat(ref name);
            Console.WriteLine("Введите фамилию ученика: ");
            string sername = Console.ReadLine();
            CheckAndCorrectFormat(ref sername);
            Console.WriteLine("Введите возраст ученика: ");
            int age = 0;

            while (true)
            {
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка! В возрасте не может быть букв");
                    Console.WriteLine("Введите еще раз: ");
                }

            }
            Student student = new Student(name,sername,age);
            Students.Add(student);
        }
        public void DeleteStudentFromSchool()
        {
            Console.WriteLine();
            
            Console.WriteLine("Выберите под каким номером отчислить студента: ");
            int num = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                try
                {
                    if (num < 1 || num > Students.Count)
                    {
                        throw new Exception(" Вы выбрали номер не из списка");
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка! " + e.Message);
                    Console.WriteLine("Повторите попытку: ");
                }
            }
            Console.WriteLine($"Студент {Students[num-1].Name} отчислен");
            Students.RemoveAt(num-1);
        }
        public void ShowListOptions()
        {
            Console.WriteLine("1. Добавить нового ученика");
            Console.WriteLine("2. Посмотреть список всех учеников");
            Console.WriteLine("3. Отчислить ученика");
            Console.WriteLine("4. Выйти из школы");
            Console.WriteLine("5. Показать список команд администрирования");
            Console.WriteLine();
        }
        public void CheckAndCorrectFormatIndexOfList(ref int num)
        {
            int c = 0;
            while (true)
            {
                try
                {
                    c++;
                    if (с != 1)
                    {
                        num = Convert.ToInt32(Console.ReadLine());
                    }
                    if (num < 1 || num > 4)
                    {
                        throw new Exception(" Вы выбрали номер не из списка");
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка! " + e.Message);
                    Console.WriteLine("Повторите попытку: ");
                }
            }
        }
        public void Exit()
        {
            Console.WriteLine("Вы вышли из школы.");
            System.Environment.Exit(0);
        }

       
        private void CheckAndCorrectFormat(ref string str)
        {
            int c = 0;
            while (true)
            {
                
                try
                {
                    c++;
                    if (c != 1)
                    {
                        str = Console.ReadLine();
                    }
                    if (str.Length < 2)
                    {
                        throw new Exception("Длина строки должна быть больше 1 символа");
                    }
                    
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (char.IsDigit(str[i]))
                        {
                            throw new Exception("В строке не должно быть цифр");
                        }
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка! " + e.Message);
                    Console.WriteLine("Повторите попытку: ");

                }
            }
        }
    }
}
