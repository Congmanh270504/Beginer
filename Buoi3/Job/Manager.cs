using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class Manager : ABC
    {
        string position;
        double positionPoint;

        public double PositionPoint
        {
            get { return positionPoint; }
            set { positionPoint = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public Manager()
            : base()
        {
            position = "Trưởng phòng";
            positionPoint = 5;
        }
        public Manager(string id, string name, double salaryPoint, int timestart, int dayoff, string position, double positionPoint)
            : base(id, name, salaryPoint, timestart, dayoff)
        {
            this.position = position;
            this.positionPoint = positionPoint;
        }
        public override char getABC()
        {
            return 'A';
        }
        public override double Salary()
        {
            return SalaryPoint * baseSalary + positionPoint * 1100;
        }
    }
}
