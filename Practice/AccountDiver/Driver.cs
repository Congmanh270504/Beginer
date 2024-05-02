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
        public Driver(string username, string password, string phone, string status, string typeCustomer, string id, string name, string typeDiver) : base(username, password, phone, status, typeCustomer)
        {
            this.typeDiver = typeDiver;
        }

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
        public string getLocationCustomer()
        {
            return Location;
        }
        public abstract long getCost();
        public abstract double payBack();
    }
}
