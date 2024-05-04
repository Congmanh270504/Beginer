using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.AccountDiver
{
    class Customer : Account
    {
        string typeCustomer, typeVehicle;
        int location, destination;
        public Customer(string username, string status, string phone, string typeCustomer) : base(username, status, phone)
        {
            this.typeCustomer = typeCustomer;
            location = setLocation();
            destination = toLocation();
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
        public int Finish { get => destination; set => destination = value; }
        public string TypeVehicle { get => typeVehicle; set => typeVehicle = value; }

        private void menu()
        {
            Console.Write("Choose your vehicle u want: ");
            Console.WriteLine("1.Moto bike\t2.Car\t3.Truck");
        }
        private void setTypeVehicle()
        {
            int choose = 0;
            menu();
            do
            {
                Console.Write("Choose your type vehicle: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        TypeVehicle = "Moto bike";
                        break;
                    case 2:
                        TypeVehicle = "Car";
                        break;
                    case 3:
                        TypeVehicle = "Truck";
                        break;
                    default:
                        Console.WriteLine("Don't have that option!! *Choose again(1 2 3)");
                        break;
                }
            } while (choose > 3);

        }
        public int toLocation()
        {
            Random a = new Random();
            return a.Next(100);
        }
        public int checkDestination()
        {
            while (destination <= location)
            {
                destination = toLocation();
            }
            return destination;
        }
        public int getLocation()
        {
            int des = checkDestination();
            return des - location;
        }

        public int getBuses()
        {
            Status = "Online";
            Console.Write("Customer location: " + Location);
            Console.Write("Type vehicle: " + TypeVehicle);
            return 1;
        }
        public void getInfor()
        {
            setTypeVehicle();
            Console.WriteLine("Username:{0} Phone:{1} Status:{2} Type customer:{3} Type vehicle:{4} Your location:{5} Destination:{6} Distance:{7}", Username, Phone, Status, TypeCustomer, TypeVehicle, location, checkDestination(), getLocation());
        }

    }
}
