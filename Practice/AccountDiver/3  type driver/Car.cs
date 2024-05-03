using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.AccountDiver
{
    class Car : Driver, IBonus
    {
        int space;
        public Car(string username, string password, string status, string phone, string typeCustomer, string id, string name, string typeDiver, string start, string finish, int distance, int time, int space) : base(username, password, status, phone, typeCustomer, id, name, typeDiver, start, finish, distance, time)
        {
            this.space = space;
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
                if (Distance == 1)
                {
                    return 7500;
                }
                for (int i = 0; i < Distance; i++)
                {
                    if (i < 2)
                    {
                        sum += 15000;
                    }
                    else if (i < 7)
                    {
                        sum += 12000;
                    }
                    else
                    {
                        sum += sum + (Distance - 7) * 8500;
                    }
                }
                return sum;
            }
            else
            {
                if (Distance == 1)
                {
                    return 7500;
                }
                for (int i = 0; i < Distance; i++)
                {
                    if (i < 2)
                    {
                        sum += 17000;
                    }
                    else if (i < 7)
                    {
                        sum += 15000;
                    }
                    else
                    {
                        sum += sum + (Distance - 7) * 10500;
                    }
                }
                return sum;
            }
        }
        public override long payBackCompy()
        {
            return getCost() * 10 / 100;
        }
        public long bonus()
        {
            long salary = getCost();
            if (salary > 2000000)
            {
                return salary + 200000;
            }
            return salary;
        }
    }

}
