using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class Production : ABC
    {
        double heavyJob;

        public double HeavyJob
        {
            get { return heavyJob; }
            set { heavyJob = value; }
        }
        public Production()
            : base()
        {
            heavyJob = 0;
        }
        public Production(string id, string name, double salaryPoint, int timestart, int dayoff, double heavyJob)
            : base(id, name, salaryPoint, timestart, dayoff)
        {
            this.heavyJob = heavyJob;
        }
        public override double Salary()
        {
            return baseSalary * SalaryPoint * (1 + 0.1);
        }
    }
}
