using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Practice.AccountDiver
{
    internal class Motorbike : Driver
    {
        public Motorbike()
        {
        }
        public Motorbike(string username, string phone, string typeCustomer, int distance, string id, string name, string typeDiver) : base(username, phone, typeCustomer, id, name, typeDiver, distance) { }
        public long surchange()
        {
            if (Time.Hour > 22 && Time.Hour < 24 && Time.Hour > 0 && Time.Hour < 5)
            {
                return getCost() + Distance * 3000;
            }
            return getCost();
        }
        public override long getCost()
        {
            int sum = 0;

            for (int i = 0; i < Distance; i++)
            {
                if (i < 2)
                {
                    sum += 4000;
                }
                else
                {
                    sum += 5000;
                }
            }
            return sum;
        }
        public override long payBackCompy()
        {
            return surchange() * 95 / 100;
        }
        public override void getInfor()
        {
            base.getInfor();
            Console.WriteLine("Cost:{0}", surchange());
        }

    }
    class ListMotobike
    {
        List<Motorbike> motobikes = new List<Motorbike>();

        XmlDocument read = new XmlDocument();
        XmlElement root;// lay phan tu dau tien cua cai list customer
        public ListMotobike()
        {
        }

        public void Input(string file)
        {
            XmlNodeList node = read.SelectNodes("/Accounts/Motobike");
            read.Load(file);// load file
            foreach (XmlNode i in node)
            {
                Motorbike moto = new Motorbike();
                moto.Username = i["username"].InnerText;
                moto.Phone = i["phone"].InnerText;
                moto.Id = i["id"].InnerText;
                moto.Name = i["name"].InnerText;
                moto.TypeDiver = i["typeDiver"].InnerText;
                motobikes.Add(moto);
            }
        }
        public void Output()
        {
            foreach (var item in motobikes)
            {
                item.getInfor();
            }
        }
        public int Count()
        {
            return motobikes.Count;
        }
        public long getRevenue()
        {
            long sum = 0;
            foreach (var item in motobikes)
            {
                sum += item.payBackCompy();
            }
            return sum;
        }
        public void getHighestCost()
        {
            long max = motobikes[0].payBackCompy();
            int index = 0;
            for (int i = 0; i < motobikes.Count; i++)
            {
                if (max < motobikes[i].payBackCompy())
                {
                    max = motobikes[i].payBackCompy();
                    index = i;
                }
            }
            motobikes[index].getInfor();
        }
    }
}
