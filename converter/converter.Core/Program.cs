using static System.Net.Mime.MediaTypeNames;

namespace converter.Core
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Converter converter = new Converter();
            double res = converter.Convert("kg", "g", "weight", 12);
            Console.WriteLine(res);
        }
    }
}