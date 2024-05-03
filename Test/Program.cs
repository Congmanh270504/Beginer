using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime check = new DateTime(2022, 5, 3, 20, 0, 0);
            TimeSpan duration = new System.TimeSpan(0, 24, 0, 0);
            DateTime newDate1 = DateTime.Now.Add(duration);
            Console.WriteLine(newDate1); // 1/19/2016 11:47:52 AM
            bool test = DateTime.Now.Hour == 23;
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(test);
            // Create a TimeSpan

            Console.ReadKey();
        }
    }
}
