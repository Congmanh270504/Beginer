using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.AccountDiver
{
    internal class Motorbike : Driver
    {
        public Motorbike(string username, string password, string status, string phone, string typeCustomer, string id, string name, string typeDiver, string start, string finish, int distance, int time) : base(username, password, status, phone, typeCustomer, id, name, typeDiver, start, finish, distance, time) { }
        public long surchange()
        {
            if (Time > 22 && Time < 24 || Time > 0 && Time < 5)
            {
                return getCost() * 3000;
            }
            return getCost();
        }
        public override long getCost()
        {
            if (Distance == 1)
            {
                return 4000;
            }
            return 2 * 8000 + (Distance - 2) * 5000;
        }
        public override long payBackCompy()
        {
            return getCost() * 5 / 100;
        }

    }
}
