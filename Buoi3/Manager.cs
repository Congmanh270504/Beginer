using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class Manager : Staff
    {
        string position, room;
        double positionPoint;

        public double PositionPoint
        {
            get { return positionPoint; }
            set { positionPoint = value; }
        }

        public string Room
        {
            get { return room; }
            set { room = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public Manager()
        {
            position = "Trưởng phòng";
            room = "Phòng hành chính";
            positionPoint = 5;
        }
        public override double Race()
        {
            return 1;
        }
        public double supManager()
        {
            return positionPoint * Staff.baseSalary;
        }
        public override long getSalary()
        {
            return Convert.ToInt64(base.getSalary() + supManager());
        }
    }
}
