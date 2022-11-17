namespace converter.Core
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Converter converter = new Converter();
            double res = converter.Convert("km", "km", 12);
            Console.WriteLine(res);
        }
    }
}