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

            Staff manh = new Staff("4ds", "Manh", 2, 4);
            manh.getInfor();
            Manager son = new Manager("4ds", "Son", 2, 4, "Truong phong", 1000);
            son.getInfor();
            Console.ReadKey();

        }
    }
}
