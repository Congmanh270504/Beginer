using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Boss
    {
        static void Main(string[] args)
        {
            MainAverageP(args);
            //MainRoomBill(args);
        }
        //
        static void MainAverageP(string[] args)
        {
            Theory OOP = new Theory("13DHTH03", "Huong doi tuong", 2, 8.9, 7.6);
            Console.WriteLine("Mon: {0}", OOP.Name);
            Console.WriteLine("Diem trung binh: " + String.Format("{0:0.000}", OOP.getAverageP()));
            Console.Write("Diem he chu:");
            OOP.convertCharP();

            Pratice techniques = new Pratice("13DHTH04", "Ki thuat lap trinh", 2, 8.9, 7.6, 5.6);
            Console.WriteLine("Mon: {0}", techniques.Name);
            Console.WriteLine("Diem trung binh: " + String.Format("{0:0.000}", techniques.getAverageP()));
            Console.Write("Diem he chu:");
            techniques.convertCharP();

            Project web = new Project("13DHTH04", "TKW", 2, 8.9, 7.6);
            Console.WriteLine("Mon: {0}", web.Name);
            Console.WriteLine("Diem trung binh: " + String.Format("{0:0.000}", web.getAverageP()));
            Console.Write("Diem he chu:");
            web.convertCharP();
        }
        // Main roomBill
        static void MainRoomBill(string[] args)
        {
            RoomA Manh = new RoomA("54323", 2, 5.3, 100, 4);
            Console.WriteLine("Tien phong: {0}", Manh.getRoomCost());

            RoomB Son = new RoomB("45213", 3, 100, 50, 5, 4);
            Console.WriteLine("Tien phong:{0}", Son.getRoomCost());
        }
    }

}
