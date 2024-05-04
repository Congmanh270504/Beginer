using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.AccountDiver
{
    internal class Motorbike : Driver
    {
        public Motorbike(string username, string status, string phone, string typeCustomer, int distance, string id, string name, string typeDiver) : base(username, status, phone, typeCustomer, id, name, typeDiver, distance) { }
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
}
