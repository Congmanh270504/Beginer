using Practice.Petrol;
using Practice.Petrol.TypeCustomer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Practice.Petrol
{
    internal class ListBill : Bill
    {
        List<ListBill> listBills = new List<ListBill>();
        List<Gasoline> gasolines = new List<Gasoline>();
        double total;
        internal List<ListBill> ListBills { get => listBills; set => listBills = value; }
        internal List<Gasoline> Gasolines { get => gasolines; set => gasolines = value; }
        public double Total { get => total; set => total = value; }

        public ListBill(double total)
        {
            this.total = total;
        }
        public ListBill()
        {
            
        }

        public void Input(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList node = read.SelectNodes("/GasolineList/Bills");
            foreach (XmlNode i in node)
            {
                ListBill temp = new ListBill();
                temp.TypeCustomer = i["typeCustomer"].InnerText;
                temp.Id = i["id"].InnerText;
                temp.Name = i["name"].InnerText;
                temp.TimeSet = Convert.ToDateTime(i["timeset"].InnerText);
                temp.Quantity = Convert.ToInt32(i["quantity"].InnerText);
                XmlNodeList nodeChild = i["Gasoline"].ChildNodes;
                foreach (XmlNode j in nodeChild)
                {
                    temp.IdItem = j["idItem"].InnerText;
                    temp.NameItem = j["nameItem"].InnerText;
                    temp.Cost = Convert.ToDouble(j["cost"].InnerText);
                }
                listBills.Add(temp);
            }
        }
        public static void menu()
        {
            Console.WriteLine("============================= Menu ==============================");
            Console.WriteLine("|| ************************** Init ****************************||");
            Console.WriteLine("|| * 1.Show Petrol list                                      * ||");
            Console.WriteLine("|| ************************** Pratice ************************ ||");
            Console.WriteLine("|| * 2.Get haunt customer                                    * ||");
            Console.WriteLine("|| * 3.Total money                                           * ||");
            Console.WriteLine("|| * 5.Get all Revenue each type vehicle                     * ||");
            Console.WriteLine("|| * 6.Get highest cost motobike                             * ||");
            Console.WriteLine("|| * 7.Get highest cost car                                  * ||");
            Console.WriteLine("|| * 8.Get highest cost truck                                * ||");
            Console.WriteLine("|| * 9.Sort driver by cost                                   * ||");
            Console.WriteLine("|| * 10.Get VIP customer                                     * ||");
            Console.WriteLine("|| * 11.Get most Time Call customer                          * ||");
            Console.WriteLine("|| * 12.Get highest revenue driver (car/truck)               * ||");
            Console.WriteLine("|| * 13.Get infor car driver have bonus                      * ||");
            Console.WriteLine("|| * 14.Get infor truck driver have bonus                    * ||");
            Console.WriteLine("|| ************************** Exit ***************************||");
            Console.WriteLine("|| * 0.Exit                                                  * ||");
            Console.WriteLine("|| ************************** End *****************************||");
            Console.WriteLine("=================================================================");
        }
        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20} {4,-20} {5,-20} {6,-20} {7,-20} {8,-20} ", "Loại KH", "Mã KH", "Tên KH", "Ngày lập", "Số lượng", "Mã hàng", "Tên hàng", "Đơn giá", "Tổng tiền");
            Console.ForegroundColor = ConsoleColor.White;
            string check = "";
            foreach (var i in listBills)
            {
                check = i.TypeCustomer;
                i.getInfor();
                switch (check)
                {
                    case "VIP":
                        VIP vip = new VIP(i.IdItem, i.NameItem, i.Cost, i.Id, i.Name, i.ItemType, i.TypeCustomer, i.TimeSet, i.Quantity);
                        Console.WriteLine(" {0,-20}đ", vip.getPromotion());
                        break;
                    case "Closest":
                        Closest closest = new Closest(i.IdItem, i.NameItem, i.Cost, i.Id, i.Name, i.ItemType, i.TypeCustomer, i.TimeSet, i.Quantity);
                        Console.WriteLine(" {0,-20}đ", closest.getPromotion());
                        break;
                    case "Haunt":
                        Haunt haunt = new Haunt(i.IdItem, i.NameItem, i.Cost, i.Id, i.Name, i.ItemType, i.TypeCustomer, i.TimeSet, i.Quantity);
                        Console.WriteLine(" {0,-20}đ", haunt.getPromotion());
                        break;
                    default:
                        Console.WriteLine("How did u get here??");
                        break;
                }
            }
        }
        public List<ListBill> getHaunt()
        {
            return listBills.Where(t => t.TypeCustomer.Equals("Haunt")).ToList();
        }
        public double Sum()
        {
            double sum = 0;
            foreach (var i in listBills)
            {
                if (i.TypeCustomer.Equals("VIP"))
                {
                    VIP vip = new VIP(i.IdItem, i.NameItem, i.Cost, i.Id, i.Name, i.ItemType, i.TypeCustomer, i.TimeSet, i.Quantity);
                    sum += vip.getPromotion();
                }
                else if (i.TypeCustomer.Equals("Closest"))
                {
                    Closest closest = new Closest(i.IdItem, i.NameItem, i.Cost, i.Id, i.Name, i.ItemType, i.TypeCustomer, i.TimeSet, i.Quantity);
                    sum += closest.getPromotion();
                }
                else
                {
                    Haunt haunt = new Haunt(i.IdItem, i.NameItem, i.Cost, i.Id, i.Name, i.ItemType, i.TypeCustomer, i.TimeSet, i.Quantity);
                    sum += haunt.getPromotion();
                }
            }
            return sum;
        }
        public double getHighestBill()
        {
        
// tìm giá trị của cái i cost so sánh thử
            return 0;
        }
        public void countVipClosest()
        {
        if() // if have vip or closest customer => getInfor()
        {
        
        }
        }
    }
}
