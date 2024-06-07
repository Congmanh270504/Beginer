using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Buoi3
{
    class ListT
    {
        List<T> listT = new List<T>();

        internal List<T> ListT1
        {
            get { return listT; }
            set { listT = value; }
        }
        XmlDocument read = new XmlDocument();

        public void Input(string file)
        {
            read.Load(file);
            XmlNodeList list = read.SelectNodes("/ListT/ABC");
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
    }
}
