using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.AccountDiver
{
    class Customer : Account
    {
        string typeCustomer, typeVehicle, location;
        public Customer(string username, string password, string phone, string status, string typeCustomer) : base(username, password, phone, status)
        {
            this.typeCustomer = typeCustomer;
        }
        public string TypeCustomer
        {
            get
            {
                if (!typeCustomer.Equals("Vip") || !typeCustomer.Equals("Normal"))
                {
                    throw new Exception("Wrong Customer type !");
                }
                return typeCustomer;
            }
            set { typeCustomer = value; }
        }

        public string TypeVehicle { get => typeVehicle; set => typeVehicle = value; }
        public string Location { get => location; set => location = value; }

        public void getBuses()
        {
            Status = "Online";
            Console.Write("Type vehicle u want ?");
            TypeVehicle = Console.ReadLine();
            Console.Write("Your location: ");
            Location = Console.ReadLine();  
        }
    }
}
