using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class Business : ABC, ITip
    {
        int minItem, item;

        public int Item
        {
            get { return item; }
            set { item = value; }
        }

        public int MinItem
        {
            get { return minItem; }
            set { minItem = value; }
        }
        public override char getABC()
        {
            if (Item == 2 * minItem)
            {
                return 'A';
            }
            else if (Item == minItem)
            {
                return 'B';
            }
            else if (Item < minItem / 2)
            {
                return 'C';
            }
            return 'D';
        }
        public Business(string id, string name, double salaryPoint, int timestart, int dayoff,int minItem,int item)
            : base(id, name, salaryPoint, timestart, dayoff)
        {
            this.minItem = minItem;
            this.item = item;
        }
        public override double Salary()
        {
            return SalaryPoint * baseSalary + Tip();
        }
        public double Tip()
        {
            int check = item - minItem;
            if (check < 0)
            {
                check = 0;
            }
            return check * 0.15;
        }

    }
}
