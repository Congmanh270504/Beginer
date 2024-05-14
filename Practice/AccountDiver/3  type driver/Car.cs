using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Practice.AccountDiver
{
    class Car : Driver, IBonus
    {
        int space;
        public Car(string username, string phone, string typeCustomer, int distance, string id, string name, string typeDiver, int space) : base(username, phone, typeCustomer, id, name, typeDiver, distance)
        {
            this.space = space;
        }
        public Car()
        {

        }
        public int Space
        {
            get
            {
                if (space != 4 && space != 7)
                {
                    throw new Exception("Wrong space car !");
                }
                return space;
            }
            set
            {
                space = value;
            }
        }

        public override long getCost()
        {
            int sum = 0;
            if (Space == 4)
            {
                for (int i = 0; i < Distance; i++)
                {
                    if (i < 2)
                    {
                        sum += 7500;
                    }
                    else if (i < 7)
                    {
                        sum += 2400;
                    }
                    else
                    {
                        sum += 8500;
                    }
                }
                return sum;
            }
            else
            {

                for (int i = 0; i < Distance; i++)
                {
                    if (i < 2)
                    {
                        sum += 8500;
                    }
                    else if (i < 7)
                    {
                        sum += 3000;
                    }
                    else
                    {
                        sum += 10500;
                    }
                }
                return sum;
            }

        }
        public override long payBackCompy()
        {
            return getCost() * 90 / 100;
        }
        public long bonus()
        {
            long salary = payBackCompy();
            if (salary > 2000000)
            {
                return salary + 200000;
            }
            return salary;
        }
        public override void getInfor()
        {
            base.getInfor();
            Console.WriteLine("Space:{0}\tCost:{1}", Space, bonus());
        }
    }
    class ListCar
    {
        List<Car> cars = new List<Car>();

        XmlDocument read = new XmlDocument();
        XmlElement root;// lay phan tu dau tien cua cai list customer
        public ListCar()
        {
        }

        public void Input(string file)
        {
            XmlNodeList node = read.SelectNodes("/Accounts/Car");
            read.Load(file);// load file
            foreach (XmlNode i in node)
            {

                Car car = new Car();
                car.Username = i["username"].InnerText;
                car.Phone = i["phone"].InnerText;
                car.Id = i["id"].InnerText;
                car.Name = i["name"].InnerText;
                car.TypeDiver = i["typeDiver"].InnerText;
                car.Space = int.Parse(i["space"].InnerText);
                cars.Add(car);
            }
        }
        public void Output()
        {
            foreach (var item in cars)
            {
                item.getInfor();
            }
        }
        public int Count()
        {
            return cars.Count;
        }
        public long getRevenue()
        {
            long sum = 0;
            foreach (var item in cars)
            {
                sum += item.payBackCompy();
            }
            return sum;
        }
        public void getHighestCost()
        {
            long max = cars[0].payBackCompy();
            int index = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                if (max < cars[i].payBackCompy())
                {
                    max = cars[i].payBackCompy();
                    index = i;
                }
            }
            cars[index].getInfor();
        }
    }

}
