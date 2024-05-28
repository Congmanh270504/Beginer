using Practice.Petrol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Petrol.TypeCustomer
{
    internal class Closest:Bill
    {
        public Closest():base()
        {
            
        }
        public Closest(string idItem, string nameItem, double cost, string id, string name, string itemType, string typeCustomer, DateTime timeSet, int quantity) : base(idItem, nameItem, cost, id, name, itemType, typeCustomer, timeSet, quantity)
        {

        }
        public override double getPromotion()
        {
            double checkCost = getCost();
            if (Quantity > 60)
            {
                return getCost() * 96 / 100;
            }
            else if (Quantity <= 50 && checkCost >= 800000)
            {
                return checkCost * 97 / 100;
            }
            return 0;
        }
        public double Deposit()
        {
            double total = getTotal();
            return total * 60 / 100;
        }
        public double Installment()
        {
            double total = getTotal();
            double deposit = Deposit();
            return 3 / 100 * (total - deposit);
        }
    }
}
