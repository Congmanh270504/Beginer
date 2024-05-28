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
        public Haunt(string idItem, string nameItem, double cost, string id, string name, string itemType, string typeCustomer, DateTime timeSet, int quantity) : base(idItem, nameItem, cost, id, name, itemType, typeCustomer, timeSet, quantity)
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
