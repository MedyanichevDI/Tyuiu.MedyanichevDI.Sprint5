using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MedyanichevDI.Sprint5.Task3.V23.Lib
{
    public class DataService : ISprint5Task3V23
    {
        public string SaveToFileTextData(int x)
        {
            double calc = Math.Round((1 + Math.Pow(x, 3)) / Math.Pow(x, 2),3);
            string tempPath = Path.GetTempPath();


            string filePath = Path.Combine(tempPath, "OutPutFileTask3.bin");


            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(calc);
            }


            byte[] fileBytes = File.ReadAllBytes(filePath);
            string base64String = Convert.ToBase64String(fileBytes);

          
            return filePath;
        }
    }
}
