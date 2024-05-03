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
        public Truck(string username, string password, string status, string phone, string typeCustomer, string id, string name, string typeDiver, string start, string finish, int distance, int time, double weight) : base(username, password, status, phone, typeCustomer, id, name, typeDiver, start, finish, distance, time)
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
                        sum += 60000;
                    }
                    else if (i < 10)
                    {
                        sum += 50000;
                    }
                    else
                    {
                        sum += sum + (Distance - 10) * 30500;
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
                        sum += 70000;
                    }
                    else if (i < 10)
                    {
                        sum += 60000;
                    }
                    else
                    {
                        sum += sum + (Distance - 10) * 40500;
                    }
                }
                return sum;
            }
        }
        public override long payBackCompy()
        {
            return getCost() * 15 / 100;
        }
        public long bonus()
        {
            long salary = getCost();
            if (salary > 3000000)
            {
                return salary + 300000;
            }
            return salary;
        }
    }
}
