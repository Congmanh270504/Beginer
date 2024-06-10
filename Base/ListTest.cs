using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Base
{
    internal class ListTest
    {
        List<Class1> ts = new List<Class1>();
        XmlDocument read = new XmlDocument();

        internal List<Class1> Ts { get => ts; set => ts = value; }
        public void Input()
        {
            read.Load("");
            XmlNodeList list = read.SelectNodes("");
            foreach (XmlNode item in list)
            {
                T temp;
                string type = item["type"].InnerText;
                string id = item["id"].InnerText;
                string name = item["name"].InnerText;
                int dayoff = int.Parse(item["dayoff"].InnerText);
                int timestart = int.Parse(item["timestart"].InnerText);
                double salaryPoint = double.Parse(item["salaryPoint"].InnerText);
                switch (type)
                {
                    case "Production":
                        temp = new Production(id, name, salaryPoint, timestart, dayoff, double.Parse(item["heabyJob"].InnerText));
                        break;
                    case "Business":
                        temp = new Business(id, name, salaryPoint, timestart, dayoff, int.Parse(item["minitem"].InnerText), int.Parse(item["item"].InnerText));
                        break;
                    case "Manager":
                        temp = new Manager(id, name, salaryPoint, timestart, dayoff, item["position"].InnerText, double.Parse(item["positionPoint"].InnerText));
                        break;
                    default:
                        throw new Exception("cc loi cai lz a` ");
                }
                listT.Add(temp);
            }
            list = read.SelectNodes("/ListT/BCD");
            foreach (XmlNode item in list)
            {
                BCD bcd = new BCD();
                bcd.Id = item["id"].InnerText;
                bcd.Name = item["name"].InnerText;
                bcd.Total = double.Parse(item["total"].InnerText);
                listT.Add(bcd);
            }
        }
        public void Output()
        {
            foreach (var item in ts)
            {
                Console.WriteLine("");
            }
        }
        public void menu()
        {
            Console.WriteLine("============================= Menu ==============================");
            Console.WriteLine("|| *********************** Show List ************************* ||");
            Console.WriteLine("|| * 1.Show Cutomer list                                     * ||");
            Console.WriteLine("|| * 2.Show Diver list                                       * ||");
            Console.WriteLine("|| ************************** Exam *************************** ||");
            Console.WriteLine("|| * 3.Count in total vehical                                * ||");
            Console.WriteLine("|| * 4.Count total customer                                  * ||");
            Console.WriteLine("|| ************************** Exit *************************** ||");
            Console.WriteLine("|| * 0.Exit                                                  * ||");
            Console.WriteLine("|| ************************** End *****************************||");
            Console.WriteLine("=================================================================");
        }
    }
}
