using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class BCD : T
    {
        double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public BCD()
            : base()
        {
            total = 0;
        }
        public BCD(string id ,string name ,double total):base(id,name)
        {
            this.total = total;
        }
        public override double Salary()
        {
            return Total * 0.15;
        }
        public override string Title()
        {
            double result = Salary();
            if (result > 10000)
            {
                return "Lao động tiên tiến";
            }
            else if (result > 20000)
            {
                return "Chiến sĩ thi đua";
            }
            return "";
        }
    }
}
