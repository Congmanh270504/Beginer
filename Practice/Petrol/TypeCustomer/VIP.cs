using Practice.Petrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice.Petrol.TypeCustomer
{
    class VIP : Bill, Payment
    {
        public VIP() : base()
        {
        }
        public VIP(string idItem, string nameItem, double cost, string id, string name, string itemType, string typeCustomer, DateTime timeSet, int quantity) : base(idItem, nameItem, cost, id, name, itemType, typeCustomer, timeSet, quantity)
        {

        }
        public override double getPromotion()
        {
            double checkCost = getCost();
            if (Quantity > 50)
            {
                return getCost() * 95 / 100;
            }
            else if (Quantity < 50 && checkCost > 600000)
            {
                return checkCost * 96 / 100;
            }
            else if (Quantity > 10)
            {
                return checkCost * 99 / 100;
            }
            return 0;
        }
        public double Deposit()
        {
            double total = getTotal();
            return total * 40 / 100;
        }
        public double Installment()
        {
            double total = getTotal();
            double deposit = Deposit();
            return 2 / 100 * (total - deposit);
        }
    }
}
