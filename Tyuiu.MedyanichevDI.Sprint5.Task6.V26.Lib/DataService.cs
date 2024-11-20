using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MedyanichevDI.Sprint5.Task6.V26.Lib
{
    public class DataService : ISprint5Task6V26
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;

            // Открываем файл с использованием StreamReader
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                // Читаем файл построчно
                while ((line = reader.ReadLine()) != null)
                {
                    // Разделяем строку на слова по пробелам и другим разделителям
                    string[] words = line.Split(new char[] { ' ', ',', '.', '!', ';', ':', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    
                    foreach (var word in words)
                    {
                        if (word == "?")
                        {
                            count++;
                        }
                    }
                }
            }

            return count; 
        }
    }
}
