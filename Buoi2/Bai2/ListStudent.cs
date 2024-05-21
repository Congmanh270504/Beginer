using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Buoi2
{
    class ListStudent
    {
        List<Student> listStudent = new List<Student>();
        XmlDocument read = new XmlDocument();

        internal List<Student> ListStudent1
        {
            get { return listStudent; }
            set { listStudent = value; }
        }

        public void Input(string file)
        {
            read.Load(file);
            XmlNodeList nodelist = read.SelectNodes("/DanhSach/Student");
            foreach (XmlNode item in nodelist)
            {
                Student temp = new Student();
                temp.Id = item["name"].InnerText;
                temp.Name = item["name"].InnerText;
                temp.Birthday = Convert.ToInt32(item["birthday"].InnerText);
                temp.Math = Convert.ToDouble(item["math"].InnerText);
                temp.Literature = Convert.ToDouble(item["literature"].InnerText);
                temp.English = Convert.ToDouble(item["english"].InnerText);

                //temp.Group = Convert.ToInt32(item["group"].InnerText);
                listStudent.Add(temp);
            }
        }
        public void Output()
        {
            foreach (var item in listStudent)
            {
                item.getInfor();
            }
        }
        public List<Student> sortPoint()
        {
            return listStudent.OrderByDescending(t => t.getPoint()).ToList(); ;
        }
        public List<Student> sortName()
        {
          return listStudent.OrderBy(a => a.Name).ThenByDescending(a => a.Math).ToList();
        }
        public List<Student> getInforPassed()
        {
            return listStudent.FindAll(a => a.checkPassed().Equals("Đậu"));
        }
        public List<Student> getInforDayBorn()
        {
            return listStudent.FindAll(a => a.Birthday > 1994 || a.Math > 9);
        }
    }
}
