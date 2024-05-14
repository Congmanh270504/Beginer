using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Practice.AccountDiver._3__type_driver
{
    internal class Truck : Driver, IBonus
    {
        double weight;
        public Truck(string username, string phone, string typeCustomer, int distance, string id, string name, string typeDiver, double weight) : base(username, phone, typeCustomer, id, name, typeDiver, distance)
        {
            this.weight = weight;
        }
        public Truck()
        {
            weight = 0;
        }
        public double Weight { get => weight; set => weight = value; }

        public override long getCost()
        {
            int sum = 0;
            if (Weight <= 3)
            {
                for (int i = 0; i < Distance; i++)
                {
                    if (i < 5)
                    {
                        sum += 12000;
                    }
                    else if (i < 10)
                    {
                        sum += 5000;
                    }
                    else
                    {
                        sum += 30500;
                    }
                }
                return sum;
            }
            else
            {

                for (int i = 0; i < Distance; i++)
                {
                    if (i < 5)
                    {
                        sum += 12000;
                    }
                    else if (i < 10)
                    {
                        sum += 5000;
                    }
                    else
                    {
                        sum += 30500;
                    }
                }
                return sum;
            }
        }
        public override long payBackCompy()
        {
            return getCost() * 85 / 100;
        }
        public long bonus()
        {
            long salary = payBackCompy();
            if (salary > 3000000)
            {
                return salary + 300000;
            }
            return salary;
        }
        public override void getInfor()
        {
            base.getInfor();
            Console.WriteLine("Weight:{0}\tCost:{1}", Weight, bonus());
        }
    }
    class ListTrucks
    {
        List<Truck> trucks = new List<Truck>();

        XmlDocument read = new XmlDocument();
        XmlElement root;// lay phan tu dau tien cua cai list customer
        public ListTrucks()
        {
        }

        public void Input(string file)
        {
            XmlNodeList node = read.SelectNodes("/Accounts/Truck");
            read.Load(file);// load file
            foreach (XmlNode i in node)
            {

                Truck truck = new Truck();
                truck.Username = i["username"].InnerText;
                truck.Phone = i["phone"].InnerText;
                truck.Id = i["id"].InnerText;
                truck.Name = i["name"].InnerText;
                truck.TypeDiver = i["typeDiver"].InnerText;
                truck.Weight = int.Parse(i["weight"].InnerText);
                trucks.Add(truck);
            }
        }
        public void Output()
        {
            foreach (var item in trucks)
            {
                item.getInfor();
            }
        }
        public int Count()
        {
            return trucks.Count;
        }
        public long getRevenue()
        {
            long sum = 0;
            foreach (var item in trucks)
            {
                sum += item.payBackCompy();
            }
            return sum;
        }
        public void getHighestCost()
        {
            long max = trucks[0].payBackCompy();
            int index = 0;
            for (int i = 0; i < trucks.Count; i++)
            {
                if (max < trucks[i].payBackCompy())
                {
                    max = trucks[i].payBackCompy();
                    index = i;
                }
            }
            trucks[index].getInfor();
        }
    }
}
