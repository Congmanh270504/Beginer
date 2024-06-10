using System.Text;

namespace Base
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int choose = 0;
            double result = 0;
            ListTest listTest = new ListTest();
            //listTest.Input();
            listTest.menu();
            do
            {
                Console.Write("Choose option: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        listTest.Output();
                        break;
                    case 2:
                       
                        break;
                    case 3:

                        break;
                    case 0:
                        Console.WriteLine("\tHave a nice day sir!!\n");
                        break;
                    default:
                        Console.WriteLine("Don't have that choose!!\n");
                        break;
                }
            } while (choose != 0);
            Console.ReadKey();
        }
    }
}
