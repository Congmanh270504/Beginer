using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginer
{
    internal class Bank
    {
        private
        string name, id;
        public long money;
        public Bank(string name, string id, long money)
        {
            this.name = name;
            this.id = id;
            this.money = money;
        }
        public void rechage(long cash)
        {
            money += cash;
            Console.WriteLine("Tai khoan cua ban sau khi nap la: " + money + "VND");
        }
        public void withdrawals(long cash)
        {
            money -= cash;
            Console.WriteLine("Tai khoan cua ban sau khi rut la: " + money + "VND");
        }
        public void checkAccount()
        {
            Console.WriteLine("So tien trong tai khoan cua ban la: " + money + "VND");
        }
    }
}
