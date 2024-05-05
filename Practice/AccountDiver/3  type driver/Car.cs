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
        public Car(string username, string phone, string typeCustomer, int distance, string id, string name, string typeDiver, int space) : base(username, phone, typeCustomer, id, name, typeDiver, distance)
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

}
