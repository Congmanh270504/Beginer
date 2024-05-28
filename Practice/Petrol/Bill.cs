using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public Bill(string idItem, string nameItem, double cost, string id, string name, string itemType, string typeCustomer, DateTime timeSet, int quantity) : base(idItem, nameItem, cost)
        {
            this.id = id;
            this.name = name;
            this.itemType = itemType;
            this.typeCustomer = typeCustomer;
            this.timeSet = timeSet;
            this.quantity = quantity;
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
            Console.Write("{0,-20} {1,-20} {2,-20} {3,-20} {4,-20} ", TypeCustomer, Id, Name, TimeSet.ToString("dd/M/yyyy"), Quantity);
        }
    }
}
