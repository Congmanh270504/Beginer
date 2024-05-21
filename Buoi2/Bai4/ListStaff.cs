using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Buoi2
{
  public class ListStaff
    {
        List<Staff> listStaff = new List<Staff>();
        XmlDocument read = new XmlDocument();

        internal List<Staff> ListStaff
        {
            get { return listStaff; }
            set { listStaff = value; }
        }

        public void Input(string file)
        {
            read.Load(file);
            XmlNodeList nodelist = read.SelectNodes("/DanhSach/Staff");
            foreach (XmlNode item in nodelist)
            {
                Staff temp = new Staff();
                temp.Id = item["name"].InnerText;
                temp.Name = item["name"].InnerText;
                temp.Department = item["department"].InnerText;
                temp.Position = item["position"].InnerText;
                temp.SalaryPoint = Convert.ToDouble(item["salaryPoint"].InnerText);
                temp.Seniority = Convert.ToInt32(item["seniority"].InnerText);
                temp.DayWork = Convert.ToInt32(item["dayWork"].InnerText);
                listStaff.Add(temp);
            }
        }
        public void Output()
        {
            foreach (var item in listStaff)
            {
                item.getInfor();
            }
        }
        List<Staff> sortSalaryPoint()
        {
            return 
        }
    }
}
