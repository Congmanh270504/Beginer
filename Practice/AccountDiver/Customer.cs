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
        int location, destination, distance, timeCall;
        public Customer()
        {
            typeCustomer = "Normal";
            typeVehicle = "Unset";
            location = destination = distance = 0;
            TimeCall = 0;
        }
        public Customer(string username, string phone, string typeCustomer) : base(username, phone)
        {
            this.typeCustomer = typeCustomer;
            location = setLocation();
            destination = toLocation();
            this.typeCustomer = "Normal";
            typeVehicle = "Unset";
            location = destination = distance = 0;
            timeCall = getTimeCall();
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
        public int Finish { get => Destination; set => Destination = value; }
        public string TypeVehicle { get => typeVehicle; set => typeVehicle = value; }
        public int Distance { get => distance; set => distance = value; }
        public int Destination { get => destination; set => destination = value; }
        public int TimeCall { get => timeCall; set => timeCall = value; }

        public static void menu()
        {
            Console.Write("Choose your vehicle u want: ");
            Console.WriteLine("1.Motobike\t2.Car\t3.Truck\t0.Exit");
        }
        public int toLocation()
        {
            Random a = new Random();
            return a.Next(500);
        }
        public int checkDestination()
        {
            while (Destination <= location)
            {
                Destination = toLocation();
            }
            return Destination;
        }
        public int getLocation()
        {
            int des = checkDestination();
            return des - location;
        }
        public int getTimeCall()
        {
            Random random = new Random();
            return random.Next(50);
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
            if (TimeCall >= 10)
            {
                TypeCustomer = "VIP";
            }
            Console.WriteLine("\tUsername:{0}\tPhone:{1}\tStatus:{2}\tType customer:{3}\tType vehicle:{4}\tYour location:{5} Destination:{6} Distance:{7}\n\tTime call driver:{8}", Username, Phone, Status, TypeCustomer, TypeVehicle, location, Destination, Distance, TimeCall);
        }


    }
    class ListCustomer
    {
        List<Customer> customers = new List<Customer>();

        XmlDocument read = new XmlDocument();
        XmlElement root;// lay phan tu dau tien cua cai list customer
        public ListCustomer()
        {
        }

        internal List<Customer> Motobike { get => customers; set => customers = value; }
        public void Input(string file)
        {
            XmlNodeList node = read.SelectNodes("/Accounts/Customer");
            read.Load(file);// load file
            foreach (XmlNode i in node)
            {

                Customer cus = new Customer();
                cus.Username = i["username"].InnerText;
                cus.Phone = i["phone"].InnerText;
                cus.TypeCustomer = i["typeCustomer"].InnerText;
                cus.TimeCall = int.Parse(i["timeCall"].InnerText);
                cus.Location = cus.setLocation();
                cus.Destination = cus.toLocation();
                cus.Distance = cus.getLocation();
                customers.Add(cus); ;
            }
        }
        public void Output()
        {
            Console.WriteLine("List customer: ");
            foreach (var item in customers)
            {
                item.getInfor();
            }
        }
        public int Count()
        {
            return customers.Count;
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
        }
        public void changeNode(Customer customer)
        {
            XmlNode node = root.SelectSingleNode("Customer[username ='" + customer.Username + "']"); // <=> /Customers/Customer[username='Username']
            if (node == null)
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
            root.ReplaceChild(Customer, node);
        }
        public void deleteNode(Customer customer)
        {
            XmlNode node = root.SelectSingleNode("Customer[username ='" + customer.Username + "']"); // <=> /Customers/Customer[username='Username']
            if (node == null)
            {
                Console.WriteLine("Not found");
                return;
            }
            root.RemoveChild(node);
        }
        public void getInforVIP()
        {
            foreach (var item in customers)
            {
                if (item.TypeCustomer.Equals("VIP"))
                {
                    updateTypeCustomer();
                    item.getInfor();
                }
            }
        }
        public void updateTypeCustomer()
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].TimeCall >= 10)
                {
                    customers[i].TypeCustomer = "VIP";
                }
            }
        }
        public void getMostTimeCall()
        {
            int max = customers[0].TimeCall;
            foreach (var item in customers)
            {
                if (item.TimeCall > max)
                {
                    max = item.TimeCall;
                }
            }
            foreach (var item in customers)
            {
                if (item.TimeCall == max)
                {
                    item.getInfor();
                }
            }
        }


    }
}
