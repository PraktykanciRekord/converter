namespace converter.Core
{
    internal static class Program

    {
        [STAThread]
        static void Main()
        {
            Converter converter = new();
            string[] array = converter.Convert("kg2", "g", 1233123123123);

            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}