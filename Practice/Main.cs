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
            mainContractSinger(args);
            //  mainEmployee(args);
            Console.ReadKey();
        }
        static void mainContractSinger(string[] args)
        {
            AtHome atHome = new AtHome("HD001","Noo", 1000000, 2);
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
    }
}
