using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal abstract class Employee
    {
        string name, id, deparment;
        long salary;
        public Employee()
        {
            this.name = "";
            this.id = "";
            this.Deparment = "";
            this.Salary = 0;
        }
        public Employee(string name, string id, string deparment, long salary)
        {
            this.name = name;
            this.id = id;
            this.Deparment = deparment;
            this.Salary = salary;
        }

        public long Salary { get => salary; set => salary = value; }
        public string Deparment
        {
            get
            {
                if (deparment.Equals("abc"))
                {
                    return deparment;
                }
                else
                {
                    return deparment;
                }
            }
            set
            {
                if (deparment.Equals("abc"))
                {
                    deparment = value;
                }
                else
                {
                    deparment = value;
                }
            }
        }

        public abstract double CalculateSalary();
        public virtual void getInfor()
        {
            Console.WriteLine("Nhan vien:\nName:{0}\nTien luong:{1}", this.name, CalculateSalary());
        }
    }
    class FullTime : Employee
    {
        int monthBonus;
        public FullTime() : base()
        {

        }
        public FullTime(string name, string id, string deparment, long salary, int monthBonus) : base(name, id, deparment, salary)
        {
            this.monthBonus = monthBonus;
        }
        public override double CalculateSalary()
        {
            return Salary + this.monthBonus;
        }
    }
    class PartTime : Employee
    {
        int workHour;
        public PartTime(string name, string id, string deparment, long salary, int workHours) : base(name, id, deparment, salary)
        {
            this.workHour = workHours;
        }

        public override double CalculateSalary()
        {
            return Salary * workHour;
        }
    }
}
