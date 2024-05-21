using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class Staff
    {
        string id, name, department, position;
        double salaryPoint;
        int seniority, dayWork;
        public double SalaryPoint
        {
            get { return salaryPoint; }
            set { salaryPoint = value; }
        }
        static int baseSalary = 1210;
        public int DayWork
        {
            get { return dayWork; }
            set { dayWork = value; }
        }

        public int Seniority
        {
            get { return seniority; }
            set { seniority = value; }
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

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string Position
        {
            set
            {
                if (!value.Equals("Lanh dao") || !value.Equals("Nhan vien"))
                {
                    throw new Exception("Error!!");
                }
                position = value;
            }
            get
            {
                return position;
            }
        }
        public Staff()
        {
            id = "unset";
            name = "unset";
            department = "unset";
            position = "unset";
            salaryPoint = 0;
            seniority = 0;
            dayWork = 0;
        }
        public long getSalary()
        {
            long a = Convert.ToInt64(SalaryPoint);
            long b = Convert.ToInt64(emulationPoint());
            return a * baseSalary * b + 1100 + (long)sup();
        }
        public double emulationPoint()
        {
            if (Position.Equals("Lanh dao"))
            {
                return 1;
            }
            else
            {
                if (DayWork > 22)
                {
                    return 1;
                }
                else if (DayWork > 20)
                {
                    return 0.8;
                }
                else
                    return 0.6;
            }
        }
        public int sup()
        {
            if (Position.Equals("Lanh dao"))
            {
                return 2000;
            }
            return 0;
        }
        public void getInfor()
        {
            long result = getSalary();
            Console.WriteLine("ID:{0} Name:{1} Department:{2} Position:{3} SalaryPoint:{4} Seniority:{5} Average:{6} DayWork:{7}", Id, Name, Department, Position, SalaryPoint, Seniority, DayWork, result);
        }
    }
}
