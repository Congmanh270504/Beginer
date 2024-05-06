using Practice.ABC;
using Practice.AccountDiver;
using Practice.AccountDiver._3__type_driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Master
    {
        static void Main(string[] args)
        {
            //mainContractSinger(args);
            //  mainEmployee(args);
            //mainABC(args);
            mainAccount(args);
            Console.ReadKey();
        }
        static void mainContractSinger(string[] args)
        {
            AtHome atHome = new AtHome("HD001", "Noo", 1000000, 2);
            atHome.getInfor();
            SmallStadium smallStadium = new SmallStadium("HD002", "Noo", 1000000, 5);
            smallStadium.getInfor();
            LargeStadium largeStadium = new LargeStadium("HD003", "Noo", 1000000, 100);
            largeStadium.getInfor();

        }
        static void mainEmployee(string[] args)
        {
            FullTime Manh = new FullTime("Manh", "4rgf", "13D", 2000000, 1000000);
            Manh.getInfor();
            PartTime Son = new PartTime("Son", "4rgf", "13D", 3000000, 15);
            Son.getInfor();
        }

        static void mainABC(string[] args)
        {
            Staff Manh = new Staff("13S", "Manh", "Cu nhan", "Viet Nam", 0.2, 1, 0.2);
            Manh.getInfor();
            Manager Linh = new Manager("13M", "Linh", "Thac si", "Nuoc ngoai", 0.6, 1, "Truong phong", 0.5);

            Linh.getInfor();
            Console.ReadKey();
        }
        static void mainAccount(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            string fileCustomer = "../../../AccountDiver/XML/Accounts.xml";
            ListCustomer listCustomer = new ListCustomer();
            ListMotobike listMotobike = new ListMotobike();
            ListTrucks listTrucks = new ListTrucks();
            int choose = 0, show = 0;
            Driver driver = null;
            Account.menu();
            do
            {
                Console.Write("Choose option: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        listCustomer.Input(fileCustomer);
                        listCustomer.Output();
                        break;
                    case 2:
                        Customer.menu();
                        do
                        {
                            Console.Write("Choose option: ");
                            show = Convert.ToInt32(Console.ReadLine());

                            switch (show)
                            {
                                case 1:
                                    listMotobike.Input(fileCustomer);
                                    listMotobike.Output();
                                    break;
                                case 2:
                                    ListCar listCar = new ListCar();
                                    listCar.Input(fileCustomer);
                                    listCar.Output();
                                    break;
                                case 3:
                                    listTrucks.Input(fileCustomer);
                                    listTrucks.Output();
                                    break;
                                case 0:
                                    Console.WriteLine("\tHave a nice day sir!!\n");
                                    break;
                                default:
                                    Console.WriteLine("Don't have that choose!!\n");
                                    break;
                            }
                        } while (show != 0); ;
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
