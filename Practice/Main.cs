using Practice.ABC;
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
            mainABC(args);
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
    }
}
