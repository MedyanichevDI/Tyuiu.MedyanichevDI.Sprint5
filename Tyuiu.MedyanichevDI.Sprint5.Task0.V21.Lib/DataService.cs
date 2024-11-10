using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.MedyanichevDI.Sprint5.Task0.V21.Lib
{
    public class DataService : ISprint5Task0V21
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });
            double res =(Math.Pow(x,2)+1)/Math.Sqrt(4*Math.Pow(x,2)-3);
            res = Math.Round(res, 3);
            File.WriteAllText(path, Convert.ToString(res));
            return path;
        }
    }
}
