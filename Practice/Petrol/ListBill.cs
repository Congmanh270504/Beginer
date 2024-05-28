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
        internal List<ListBill> ListBills { get => listBills; set => listBills = value; }
        internal List<Gasoline> Gasolines { get => gasolines; set => gasolines = value; }

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
                    Gasoline tmp = new Gasoline();
                    tmp.IdItem = j["idItem"].InnerText;
                    tmp.NameItem = j["nameItem"].InnerText;
                    tmp.Cost = Convert.ToDouble(j["cost"].InnerText);
                    temp.gasolines.Add(tmp);
                }
                listBills.Add(temp);
            }
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
                foreach (Gasoline j in i.gasolines)
                {
                    j.getInfor();
                    switch (check)
                    {
                        case "VIP":
                            VIP vip = new VIP(j.IdItem, j.NameItem, j.Cost, i.Id, i.Name, i.ItemType, i.TypeCustomer, i.TimeSet, i.Quantity);
                            Console.WriteLine(" {0,-20}đ", vip.getPromotion());
                            break;
                        case "Closest":
                            Closest closest = new Closest(j.IdItem, j.NameItem, j.Cost, i.Id, i.Name, i.ItemType, i.TypeCustomer, i.TimeSet, i.Quantity);
                            Console.WriteLine(" {0,-20}đ", closest.getPromotion());
                            break;
                        case "Haunt":
                            Haunt haunt = new Haunt(j.IdItem, j.NameItem, j.Cost, i.Id, i.Name, i.ItemType, i.TypeCustomer, i.TimeSet, i.Quantity);
                            Console.WriteLine(" {0,-20}đ", haunt.getPromotion());
                            break;
                        default:
                            Console.WriteLine("How did u get here??");
                            break;
                    }
                }
            }
        }
    }
}
