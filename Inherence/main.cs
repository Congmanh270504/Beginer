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
            main4Wheels(args);
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
    }
}
