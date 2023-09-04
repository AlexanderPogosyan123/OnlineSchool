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
            
            Console.WriteLine("Выберите действие из списка(введите просто цифру): ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            school.CheckAndCorrectFormatIndexOfList( ref num);

            

        }
    }
}