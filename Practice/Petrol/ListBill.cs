using Practice.Petrol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Practice.Petrol
{
    internal class ListBill:Bill
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
            foreach (var item in listBills)
            {
                item.getInfor();
            }
        }
    }
}
