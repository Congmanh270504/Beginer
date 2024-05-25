using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Petrol
{
     class Bill : Gasoline
    {
        string id, name, itemType, typeCustomer;
        DateTime timeSet;
        int quantity;

        public string TypeCustomer
        {
            get { return typeCustomer; }
            set { typeCustomer = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ItemType
        {
            get { return itemType; }
            set { itemType = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime TimeSet { get => timeSet; set => timeSet = value; }

        public Bill()
            : base()
        {
            itemType = "";
            TimeSet = DateTime.Now;
            quantity = 0;
            typeCustomer = "";
        }
        public virtual double getPromotion()
        {
            return 0;
        }
        public double getCost()
        {
            return Quantity * Cost;
        }
        public double getTotal()
        {
            return getCost() - getPromotion();
        }
        public void getInfor()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", TypeCustomer, Id, Name, TimeSet, Quantity);
            Console.WriteLine("{0}\t{1}\t{2}", IdItem, NameItem, Cost);
        }
    }
}
