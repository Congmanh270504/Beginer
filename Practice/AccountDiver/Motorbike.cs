using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.AccountDiver
{
    internal class Motorbike : Driver
    {
        string start, finish;
        int distance;
        DateTime time = DateTime.Now;

        public Motorbike(string username, string password, string phone, string status, string typeCustomer, string id, string name, string typeDiver, string start, string finish, int distance) : base(username, password, phone, status, typeCustomer, id, name, typeDiver)
        {
            this.start = start;
            this.finish = finish;
            this.distance = distance;
        }
        public string Start { get => start; set => start = value; }
        public string Finish { get => finish; set => finish = value; }
        public int Distance { get => distance; set => distance = value; }

        public long surchange()
        {
            if (time.Hour > 22 && time.Hour < 24 || time.Hour > 0 && time.Hour < 5)
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
        public override double payBack()
        {
            return 5 / 100;
        }
    }
}
