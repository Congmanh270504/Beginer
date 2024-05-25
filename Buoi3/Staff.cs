using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class Staff
    {

        public static long baseSalary = 1150;
        string id, name;
        int dayoff, timeStart;
        long salary;
        double salaryPoint;

        public double SalaryPoint
        {
            get { return salaryPoint; }
            set { salaryPoint = value; }
        }

        public int TimeStart
        {
            get { return timeStart; }
            set { timeStart = value; }
        }

        public int Dayoff
        {
            get { return dayoff; }
            set { dayoff = value; }
        }

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


        public int Daywork
        {
            get { return dayoff; }
            set { dayoff = value; }
        }

        public long Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public Staff()
        {
            id = "";
            name = "";
            dayoff = 0;
            salaryPoint = 0;
            timeStart = DateTime.Today.Year;
            salary = 0;
            dayoff = 0;
        }
        public Staff(string id, string name, int daywork, double salaryPoint, int timestart, long salary, int dayoff)
        {
            this.id = id;
            this.name = name;
            this.dayoff = daywork;
            this.salaryPoint = salaryPoint;
            this.timeStart = timeStart;
            this.salary = salary;
            this.dayoff = dayoff;
        }
        public long supTimeStart()
        {
            int check = DateTime.Today.Year - timeStart;
            if (check >= 5)
            {
                return check * baseSalary / 100;
            }
            return 0;
        }

        public virtual double Race()
        {
            if (dayoff <= 1)
            {
                return 1;
            }
            else if (dayoff <= 3)
            {
                return 0.75;
            }
            else
            {
                return 0.5;
            }
        }
        public virtual long getSalary()
        {
            return Convert.ToInt64(baseSalary * SalaryPoint * Race() + supTimeStart());
        }

        public void getInfor()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", Id, Name, TimeStart, Dayoff, SalaryPoint, Race(), supTimeStart(), getSalary());
        }
    }
}
