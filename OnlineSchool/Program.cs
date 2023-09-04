namespace OnlineSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здраствуйте! Введите наименование школы: ");
            string schoolName = Console.ReadLine();
            School school = new School(schoolName);
            Console.WriteLine($"Школа {school.Name} успешна создана!");
            Console.WriteLine();

            Console.WriteLine("Список Команд для Администрирования: ");

            school.ShowListOptions();


            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите действие из списка(введите просто цифру): ");
                int num = Convert.ToInt32(Console.ReadLine());

                school.CheckAndCorrectFormatIndexOfList(ref num);
                int c = 0;
                switch (num)
                {
                    case 1:
                        c++;
                        school.AddNewStudent();
                        break;
                    case 2:
                        school.PrintAllStudents();
                        break;
                    case 3:
                        if (c == 0)
                        {
                            Console.WriteLine("В школе пока нет студентов, чтобы кого-то удалить");
                        }
                        else
                        {
                            school.DeleteStudentFromSchool();
                        }
                            break;
                    case 4:
                        school.Exit();
                        break;
                    case 5:
                        school.ShowListOptions();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}