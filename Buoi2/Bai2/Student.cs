using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class Student
    {
        string id, name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        int birthday;

        public int Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        double math, literature, english;

        public double English
        {
            get { return english; }
            set { english = value; }
        }

        public double Literature
        {
            get { return literature; }
            set { literature = value; }
        }

        public double Math
        {
            get { return math; }
            set { math = value; }
        }
        public Student()
        {
            id = "unset";
            name = "unset";
            birthday = 0;
            math = 0;
            literature = 0;
            english = 0;
        }
        public Student(string id, string name, int birtday, double math, double literature, double english)
        {
            this.id = id;
            this.name = name;
            this.birthday = birthday;
            this.math = math;
            this.literature = literature;
            this.english = english;
        }
        public Student(Student std)
        {
            this.id = std.id;
            this.name = std.name;
            this.birthday = std.birthday;
            this.math = std.math;
            this.literature = std.literature;
            this.english = std.english;
        }
        public double getPoint()
        {
            return Math + Literature + English * 2;
        }
        public string checkPassed()
        {
            double result = getPoint();
            if (result > 25)
            {
                return "Đậu";
            }
            else
            {
                return "Rớt";
            }

        }
        public void getInfor()
        {
            double average = getPoint();
            string check = checkPassed();
            Console.WriteLine("ID:{0} Name:{1} Year born:{2} Math:{3} Literature:{4} English:{5} Average:{6} Result:{7}", Id, Name, Birthday, Math, Literature, English, average, check);
        }
    }
}
