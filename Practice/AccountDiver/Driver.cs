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
        string start, finish;
        int distance;
        int time = DateTime.Now.Hour;

        public Driver(string username, string password, string status, string phone, string typeCustomer, string id, string name, string typeDiver, string start, string finish, int distance, int time) : base(username, password, status, phone, typeCustomer)
        {
            this.typeDiver = typeDiver;
            this.start = start;
            this.finish = finish;
            this.distance = distance;
            this.time = time;
        }
        public string Start { get => start; set => start = value; }
        public string Finish { get => finish; set => finish = value; }
        public int Distance { get => distance; set => distance = value; }
        public int Time { get => time; set => time = value; }


        public string TypeDiver
        {
            get
            {
                if (!typeDiver.Equals("Moto bike") || !typeDiver.Equals("Car") || !typeDiver.Equals("Truck"))
                {
                    throw new Exception("Wrong Diver type !");
                }
                return typeDiver;
            }
            set { typeDiver = value; }
        }


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

    }
}
