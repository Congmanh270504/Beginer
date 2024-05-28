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
        public void getInfor()
        {
            Console.WriteLine("{0}\t{1}\t{2}", IdItem, NameItem, Cost);
        }

    }
}
