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
        int distance;
        DateTime time = DateTime.Now;
        protected Driver()
        {
            id = "Unset";
            name = "Unset";
            typeDiver = "Unset";
            distance = 0;
        }
        public Driver(string username, string phone, string typeCustomer, string id, string name, string typeDiver, int distance) : base(username, phone, typeCustomer)
        {
            this.typeDiver = typeDiver;
            this.id = id;
            this.name = name;
            this.distance = distance;
        }

        public int Distance { get => distance; set => distance = value; }
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
            signIn();
            Console.WriteLine("Your driver: ");
            Console.WriteLine("ID:{0}\tDriver name:{1}\tUsername:{2}\tPhone:{3}\tType driver:{4}\tStatus:{5}\tDistance:{6}", Id, Name, Username, Phone, TypeDiver, Status, Distance);
        }

    }
}
