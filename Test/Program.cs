namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan start = new TimeSpan(22, 0, 0); //10 o'clock
            TimeSpan end = new TimeSpan(5, 0, 0); //12 o'clock
            DateTime time = DateTime.Now;
            if (time.Hour > start.Hours && time.Hour < end.Hours)
            {
                Console.WriteLine("true");
            }
        }
    }
}
