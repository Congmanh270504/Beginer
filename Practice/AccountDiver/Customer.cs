using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.AccountDiver
{
    class Customer : Account
    {
        string typeCustomer,typeVehicle;
        int location;
        public Customer(string username, string password, string phone, string status, string typeCustomer) : base(username, password, status, phone)
        {
            this.typeCustomer = typeCustomer;
            location = setLocation();
        }
        public string TypeCustomer
        {
            get
            {
                if (!typeCustomer.Equals("VIP") && !typeCustomer.Equals("Normal"))
                {
                    throw new Exception("Wrong Customer type !");
                }
                return typeCustomer;
            }
            set { typeCustomer = value; }
        }

        public int Location { get => location; set => location = value; }

        private void menu()
        {
            Console.Write("Choose your vehicle u want: ");
            Console.WriteLine("1.Moto bike\t2.Car\t3.Truck");
        }
        private void setTypeVehicle()
        {
            int choose = 0;
            menu();
            choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    typeVehicle= "Moto bike";
                    break; 
                case 2:
                    typeVehicle = "Car";
                    break;
                case 3:
                    typeVehicle = "Truck";
                    break;
                default:
                    Console.WriteLine("Don't have that option!!");
                    break;
            }
            
        }
        public void getBuses()
        {
            Status = "Online";
            Console.Write("Customer location: " + Location);
            Console.Write("Type vehicle: " + typeVehicle);
            setTypeVehicle();
        }
        public void getInfor()
        {
            setTypeVehicle();
            Console.WriteLine("Username:{0}\tPhone:{1}\tStatus:{2}\tType customer:{3}\tType vehicle:{4}", Username, Phone, Status, TypeCustomer, typeVehicle);
        }
    }
}
