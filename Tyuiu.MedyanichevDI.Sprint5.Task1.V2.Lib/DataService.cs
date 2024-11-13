using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.MedyanichevDI.Sprint5.Task2.V2.Lib
{
    public class DataService : ISprint5Task1V2
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists) { File.Delete(path); }

            double res;
            string strRes;
            for (int x = startValue; x <= stopValue; x++)
            {
                res = (2 * x - 3) / Math.Cos(x) - 2 * x;
                strRes = Convert.ToString(res);

                if (Math.Cos(x) - 2 * x == 0)
                {
                    File.AppendAllText(path, "0");
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, strRes + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strRes);
                }
            }
            return path;
        }
        
    }
}
