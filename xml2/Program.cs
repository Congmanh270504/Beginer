using System;
using System.Xml;

namespace ReadXMLfromURL
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    class Class1
    {
        static void Main(string[] args)
        {
            string data;

            StreamReader read = new StreamReader("E:\\CMạnh\\Beginer\\xml2\\test.txt");
            data = read.ReadLine();
            while (data != null)
            {
                Console.WriteLine(data);
                data = read.ReadLine();
            }
            read.Close();
            Console.ReadKey();
        }
    }
}
