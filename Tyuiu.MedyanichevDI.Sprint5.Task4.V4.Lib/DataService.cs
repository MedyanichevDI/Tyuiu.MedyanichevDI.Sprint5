using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MedyanichevDI.Sprint5.Task4.V4.Lib
{
    public class DataService : ISprint5Task4V4
    {
        public double LoadFromDataFile(string path)
        {

            string content;
            using (StreamReader sr = new StreamReader(path))
            {
                content = sr.ReadToEnd().Trim();
            }

            double x;
            if (!double.TryParse(content, NumberStyles.Any, CultureInfo.InvariantCulture, out x))
            {
                content = content.Replace(',', '.');
            }

            double y = Math.Round((1 * x) / Math.Cos(x)*4,3);

            return y;

        }
    }
}
