using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MedyanichevDI.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                List<double> positiveNumbers = new List<double>();

                string line;

                while ((line = reader.ReadLine()) != null)
                {

                    var values = line.Split(new[] { ' ', ',', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries);


                    foreach (var value in values)
                    {
                        if (double.TryParse(value, out double number) && number / 5 == 0)
                        {
                            positiveNumbers.Add(number);
                        }
                    }
                }
                return Math.Round(positiveNumbers.Average(), 3);
            }
        }
    }
}

