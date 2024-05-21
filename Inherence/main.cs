using Inherence.RealEstate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherence.Employee
{
    internal class main
    {
        static void Main(string[] args)
        {
            //mainStaff(args);
            //main4Wheels(args);
            mainRealEstate(args);
            Console.ReadKey();

        }

        static void mainStaff(string[] args)
        {

            Staff manh = new Staff("4ds", "Manh", 2, 4);
            manh.getInfor();
            Manager son = new Manager("4ds", "Son", 2, 4, "Truong phong", 1000);
            son.getInfor();

        }
        static void main4Wheels(string[] args)
        {

            External thanhbuoi = new External();
            thanhbuoi.input();
            thanhbuoi.output();
            Console.ReadLine();

        }
        static void mainRealEstate(string[] args)
        {
            string file = "../../../RealEstate/RealEstate.xml";
            RealEstateList realEstateList = new RealEstateList();
            realEstateList.Input(file);
            //realEstateList.Output();
            Console.WriteLine("In total value Real Estate: {0}", realEstateList.getTotalValue());
            Console.ReadKey(true);
        }
    }
}
