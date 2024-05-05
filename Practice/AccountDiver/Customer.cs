using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Practice.AccountDiver
{
    class Customer : Account
    {
        string typeCustomer, typeVehicle;
        int location, destination;
        public Customer(string username, string phone, string typeCustomer) : base(username, phone)
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

        public void menu()
        {
            Console.Write("Choose your vehicle u want: ");
            Console.WriteLine("1.Moto bike\t2.Car\t3.Truck\t0.Exit");
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
        public void callVehicle()
        {
            int choose = 0;
            signIn();
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
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Don't have that option!! *Choose again(1 2 3)");
                        break;
                }
            } while (choose > 3 && choose != 0);
        }
        public void getInfor()
        {
            Console.WriteLine("Username:{0} Phone:{1} Status:{2} Type customer:{3} Type vehicle:{4} Your location:{5} Destination:{6} Distance:{7}", Username, Phone, Status, TypeCustomer, TypeVehicle, location, checkDestination(), getLocation());
        }

    }
    class CustomerBLL
    {
        XmlDocument read = new XmlDocument();
        XmlElement root;// lay phan tu dau tien cua cai list customer
        string fileXML = "E:\\byMyOwn\\Hoc C#\\Beginer\\Practice\\AccountDiver\\XML\\Customer.xml";
        public CustomerBLL()
        {
            read.Load(fileXML);// load file
            root = read.DocumentElement;// phan tu dau tien cua list
        }
        public void add(Customer customer)
        {
            XmlElement Customer = read.CreateElement("Customertomer");// tao thg Customer kieu class Customertomer

            XmlElement username = read.CreateElement("username");
            username.InnerText = customer.Username; // gan gia tri cho bien
            Customer.AppendChild(username);// cho thg username thg con thg Customer

            XmlElement phone = read.CreateElement("phone");
            phone.InnerText = customer.Phone;
            Customer.AppendChild(phone);

            XmlElement typeCustomertomer = read.CreateElement("typeCustomertomer");
            typeCustomertomer.InnerText = customer.TypeCustomer;
            Customer.AppendChild(typeCustomertomer);

            root.AppendChild(Customer);//  dua vao cai list
            read.Save(fileXML); // nho luu lai file
        }
        public void changeInfor(Customer customer)
        {
            XmlNode nameCustomer = root.SelectSingleNode("Customer[username ='" + customer.Username + "']"); // <=> /Customers/Customer[username='Username']
            if (nameCustomer == null)
            {
                Console.WriteLine("Not found");
                return;
            }
            XmlElement Customer = read.CreateElement("Customertomer");// tao thg Customer kieu class Customertomer

            XmlElement username = read.CreateElement("username");
            username.InnerText = customer.Username; // gan gia tri cho bien
            Customer.AppendChild(username);// cho thg username thg con thg Customer

            XmlElement phone = read.CreateElement("phone");
            phone.InnerText = customer.Phone;
            Customer.AppendChild(phone);

            XmlElement typeCustomertomer = read.CreateElement("typeCustomertomer");
            typeCustomertomer.InnerText = customer.TypeCustomer;
            Customer.AppendChild(typeCustomertomer);
            //thay the node con cu = con moi 
            root.ReplaceChild(Customer, nameCustomer); read.Save(fileXML);
        }
    }
}
