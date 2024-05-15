using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.AccountDiver
{
    abstract class Driver : Customer
    {
        string id, name, typeDiver;
        DateTime time = DateTime.Now;
        protected Driver()
        {
            id = "Unset";
            name = "Unset";
            typeDiver = "Unset";
            Distance = getLocation();
        }
        public Driver(string username, string phone, string typeCustomer, string id, string name, string typeDiver, int distance) : base(username, phone, typeCustomer)
        {
            this.typeDiver = typeDiver;
            this.id = id;
            this.name = name;
        }

        public DateTime Time { get => time; set => time = value; }
        public string Id { get => id; set => id = value; }


        public string TypeDiver
        {
            get => typeDiver; set => typeDiver = value;
        }

        public string Name { get => name; set => name = value; }

        public int getLocationCustomer()
        {
            return Location;
        }
        public abstract long getCost();
        public abstract long payBackCompy();
        public long reduceVipCus()
        {
            if (TypeCustomer.Equals("VIP") && getCost() > 200000)
            {
                return getCost() * 90 / 100;
            }
            return getCost();
        }
        public new virtual void getInfor()
        {
            Console.WriteLine("ID:{0}\tDriver name:{1}\tUsername:{2}\tPhone:{3}\tType driver:{4}\tStatus:{5} Distance:{6}", Id, Name, Username, Phone, TypeDiver, Status, Distance);
        }
        public new static void menu()
        {
            Console.Write("Choose your vehicle u want to sort: ");
            Console.WriteLine("1.Motobike\t2.Car\t3.Truck\t0.Exit");
        }
    }
}
