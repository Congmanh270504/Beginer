using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ABC
{
    class Manager : ABC
    {
        string position;
        double positionpoint;
        public Manager(string id, string name, string degree, string place, double salarypoint, int error, string position, double positionpoint)
            : base(id, name, degree, place, salarypoint, error)
        {
            this.position = position;
            this.positionpoint = positionpoint;
        }
        public override double bonus()
        {
            return positionpoint * basesalary;
        }
        public override void getInfor()
        {
            base.getInfor();
            Console.WriteLine("Position:{0} Position Point: {1}", position, positionpoint);
            Console.WriteLine("Salary:{0} ", realSalary());

        }
    }
}
