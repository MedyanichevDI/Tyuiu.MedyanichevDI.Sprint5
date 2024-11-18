using Tyuiu.MedyanichevDI.Sprint5.Task5.V27.Lib;

namespace Tyuiu.MedyanichevDI.Sprint5.Task5.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path;
            Console.Title = "Спринт #5 | Выполнил: Медяничев Денис Игоревич | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #27                                                              *");
            Console.WriteLine("* Выполнил: Медяничев Денис Игоревич| АСОиУб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите путь к файлу:");

            path = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.LoadFromDataFile(path));
        }
    }
}
