using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.AccountDiver._3__type_driver
{
    internal class Truck : Driver, IBonus
    {
        double weight;
        public Truck(string username, string status, string phone, string typeCustomer, int distance, string id, string name, string typeDiver, double weight) : base(username, status, phone, typeCustomer, id, name, typeDiver, distance)
        {
            this.weight = weight;
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
}
