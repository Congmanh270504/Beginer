using Practice.Petrol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Petrol.TypeCustomer
{
    internal class Haunt:Bill
    {
        public Haunt():base()
        {
        }
        public override double getPromotion()
        {
            double checkCost = getCost();
            if (checkCost > 1000000)
            {
                return getCost() * 97 / 100;
            }
            return 0;
        }
    }
}
