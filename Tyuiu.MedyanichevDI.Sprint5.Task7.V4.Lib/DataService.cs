using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MedyanichevDI.Sprint5.Task7.V4.Lib
{
    public class DataService : ISprint5Task7V4
    {
        public string LoadDataAndSave(string path)
        {
            string path2 = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V12.txt" });

            FileInfo f = new FileInfo(path2);
            if (f.Exists)
            {
                File.Delete(path2);
            }

            string result = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char c in line)
                    {
                        if (c >= 'А'  && c <= 'Я')
                        {
                            result += (char)(c - '#');
                        }
                        else
                        {
                            result += c;
                        }
                    }
                }
            }
            return result;
        }
    }
}
