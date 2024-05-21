using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Buoi2
{
    class Teacher
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        int group;

        public int Group
        {
            get { return group; }
            set { group = value; }
        }
        public Teacher()
        {
            name = "";
            group = 0;
        }
        public Teacher(string name, int group)
        {
            this.name = name;
            this.group = group;
        }
        public void getInfor()
        {
            Console.WriteLine("Name teacher:{0}\tGroup:{1}", Name, Group);
        }
    }
    class ListTeacher
    {
        List<Teacher> listTeachers = new List<Teacher>();
        XmlDocument read = new XmlDocument();
        internal List<Teacher> ListTeachers
        {
            get { return listTeachers; }
            set { listTeachers = value; }
        }
        public void Input(string file)
        {
            read.Load(file);
            XmlNodeList nodelist = read.SelectNodes("/DanhSach/Teacher");
            foreach (XmlNode item in nodelist)
            {
                Teacher temp = new Teacher();
                temp.Name = item["name"].InnerText;
                temp.Group = Convert.ToInt32(item["group"].InnerText);
                listTeachers.Add(temp);
            }
        }
        public void Output()
        {
            foreach (var item in listTeachers)
            {
                item.getInfor();
            }
        }
        public int getTotalGrp()
        {
            int sum=0;
            foreach (var item in listTeachers)
            {
                sum += item.Group;
            }
            return sum;
        }
        public void sortName()
        {
            listTeachers = listTeachers.OrderBy(t => t.Name).ToList(); ;
        }
        public void sortGroup()
        {
            listTeachers = listTeachers.OrderByDescending(t => t.Group).ToList(); ;
        }
    }
}
