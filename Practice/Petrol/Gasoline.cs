using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Petrol
{
    class Gasoline
    {
        string idItem, nameItem;
        double cost;

        public string NameItem
        {
            get { return nameItem; }
            set { nameItem = value; }
        }

        public string IdItem
        {
            get { return idItem; }
            set { idItem = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public Gasoline()
        {
            idItem = "";
            nameItem = "";
            cost = 0;
        }
        public Gasoline(string idItem, string nameItem, double cost)
        {
            this.idItem = idItem;
            this.nameItem = nameItem;
            this.cost = cost;
        }
        public void getInfor()
        {
            Console.Write("{0,-20} {1,-20} {2,-20}", IdItem, NameItem, Cost);
        }

    }
}
