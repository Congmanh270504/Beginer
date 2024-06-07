using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    abstract class ABC : T
    {

        public static long baseSalary = 1210;
        int dayoff, timeStart;
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

        public ABC()
        {
            dayoff = 0;
            salaryPoint = 0;
            timeStart = DateTime.Today.Year;
            dayoff = 0;
        }
        public ABC(string id, string name, double salaryPoint, int timestart, int dayoff)
            : base(id, name)
        {
            this.salaryPoint = salaryPoint;
            this.timeStart = timeStart;
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
        public abstract char getABC();
        public double Race()
        {
            char check = getABC();
            if (check == 'A')
            {
                return 1;
            }
            else if (check == 'B')
            {
                return 0.75;
            }
            else if (check == 'C')
            {
                return 0.5;
            }
            else
                return 0;
        }
        public double getSalary()
        {
            return Salary() + supTimeStart();
        }

        public virtual void getInfor()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", Id, Name, TimeStart, Dayoff, SalaryPoint);
        }
        public override string Title()
        {
            char check = getABC();
            if (check == 'A')
            {
                return "Chiến sĩ thi đua";
            }
            else if (check=='B')
            {
                return "Lao động tiên tiến";
            }
            return "";
        }
    }
}
