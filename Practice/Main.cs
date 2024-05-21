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
            ListCar listCar = new ListCar();
            ListTrucks listTrucks = new ListTrucks();
            int choose = 0, show = 0, result, check = 0;

            listCustomer.Input(fileCustomer);
            listMotobike.Input(fileCustomer);
            listCar.Input(fileCustomer);
            listTrucks.Input(fileCustomer);
            List<Car> checkCar;
            List<Truck> checkTruck;
            Account.menu();
            do
            {
                Console.Write("Choose option: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
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
                                    Console.WriteLine("Your driver: ");
                                    listMotobike.Output();
                                    break;
                                case 2:
                                    Console.WriteLine("Your driver: ");
                                    listCar.Output();
                                    break;
                                case 3:
                                    Console.WriteLine("Your driver: ");
                                    listTrucks.Output();
                                    break;
                                case 0:
                                    Console.WriteLine("\tBack to menu 1!!\n");
                                    break;
                                default:
                                    Console.WriteLine("Don't have that choose!!\n");
                                    break;
                            }
                        } while (show != 0); ;
                        break;
                    case 3:
                        result = listCar.Count() + listMotobike.Count() + listTrucks.Count();
                        Console.WriteLine("Total vehicle type:{0} ", result);
                        break;
                    case 4:
                        result = listCustomer.Count();
                        Console.WriteLine("Total customers:{0} ", result);
                        break;
                    case 5:
                        result = Convert.ToInt32(listMotobike.getRevenue());
                        Console.WriteLine("Revenue motobikes:{0} ", result);
                        result = Convert.ToInt32(listCar.getRevenue());
                        Console.WriteLine("Revenue cars:{0} ", result);
                        result = Convert.ToInt32(listTrucks.getRevenue());
                        Console.WriteLine("Revenue trucks:{0} ", result);
                        break;
                    case 6:
                        Console.WriteLine("Highest motobike cost is:");
                        listMotobike.getHighestCost();
                        break;
                    case 7:
                        Console.WriteLine("Highest car cost is:");
                        listCar.getHighestCost();
                        break;
                    case 8:
                        Console.WriteLine("Highest truck cost is:");
                        listTrucks.getHighestCost();
                        break;
                    case 9:
                        Driver.menu();
                        do
                        {
                            Console.Write("Choose option: ");
                            show = Convert.ToInt32(Console.ReadLine());
                            switch (show)
                            {
                                case 1:
                                    Console.WriteLine("Your driver: ");
                                    listMotobike.sortCostIncrease();
                                    listMotobike.Output();
                                    break;
                                case 2:
                                    Console.WriteLine("Your driver: ");
                                    listCar.sortCostIncrease();
                                    listCar.Output();
                                    break;
                                case 3:
                                    Console.WriteLine("Your driver: ");
                                    listTrucks.sortCostIncrease();
                                    listTrucks.Output();
                                    break;
                                case 0:
                                    Console.WriteLine("\tBack to menu 1!!\n");
                                    break;
                                default:
                                    Console.WriteLine("Don't have that choose!!\n");
                                    break;
                            }
                        } while (show != 0); ;
                        break;
                    case 10:
                        Console.WriteLine("VIP customer: ");
                        listCustomer.getInforVIP();
                        break;
                    case 11:
                        Console.WriteLine("Most time call customer: ");
                        listCustomer.getMostTimeCall();
                        break;
                    //case 12:
                    //    Console.WriteLine("Highest revenue driver: ");
                    //    result = listCar.getHighestCost();
                    //    check = listTrucks.getHighestCost();
                    //    if (result < check)
                    //    {
                    //        listCar.getHighestCostCar();
                    //    }
                    //    else if (result == check)
                    //    {
                    //         listCar.getHighestCostCar();
                    //         listTrucks.getHighestCostTruck();
                    //    }
                    //    else
                    //    {
                    //         listTrucks.getHighestCostTruck();
                    //    }
                    //    break;
                    case 13:
                        Console.WriteLine("Get infor car driver have bonus: ");
                        listCar.getInforBonusCar();
                        break;
                    case 14:
                        Console.WriteLine("Most time call customer: ");
                        listTrucks.getInforBonusTruck();
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
