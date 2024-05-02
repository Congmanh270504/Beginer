using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ABC
{
    interface Isup
    {
        public double sup();
    }
    class Staff : ABC, Isup
    {
        double tip;
        public Staff(string id, string name, string degree, string place, double salarypoint, int error, double tip)
            : base(id, name, degree, place, salarypoint, error)
        {
            this.tip = tip;
        }
        public override double bonus()
        {
            return tip * 5000000;
        }
        public override double realSalary()
        {
            if (Error == 0)
            {
                return getSalary();
            }
            else if (Error == 1)
            {
                return getSalary() * 0.75;
            }
            else
                return realSalary() * 0.5;
        }
        public double sup()
        {
            if (Place.Equals("Nuoc ngoai"))
            {
                return basesalary * 2;
            }
            return basesalary;
        }
        public override void getInfor()
        {
            base.getInfor();
            Console.WriteLine("Tip:{0} Sup:{1}", tip, sup());
            Console.WriteLine("Salary:{0} ", realSalary());
        }
    }
}
