using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice.AccountDiver
{
    class Account
    {
        string username, password, phone, status;
        public Account(string username, string phone)
        {
            this.username = username;
            this.phone = phone;
            status = "Offline";
            password = "12345";
        }
        public Account()
        {
            username = "";
            password = "";
            status = "Offline";
            phone = "";
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Status
        {
            get
            {
                if (!status.Equals("Online") && !status.Equals("Offline"))
                {
                    throw new Exception("Wrong status type !");
                }
                return status;
            }
            set { status = value; }
        }
        public string signIn()
        {
            Status = "Online";
            return Status;
        }
        public string signOut()
        {
            Status = "Offline";
            return Status;
        }
        public int setLocation()
        {
            Random a = new Random();
            return a.Next(50);
        }
        public static void menu()
        {
            Console.WriteLine("============================= Menu ==============================");
            Console.WriteLine("|| ************************** Init ****************************||");
            Console.WriteLine("|| * 1.Show Cutomer list                                     * ||");
            Console.WriteLine("|| * 2.Show Diver list                                       * ||");
            Console.WriteLine("|| ************************** Format **************************||");
            Console.WriteLine("|| * 3.Insert Head                                           * ||");
            Console.WriteLine("|| * 4.Insert Tail                                           * ||");
            Console.WriteLine("|| * 5.Insert node p after q                                 * ||");
            Console.WriteLine("|| * 6.Find node x                                           * ||");
            Console.WriteLine("|| ************************** WriteFile ***********************||");
            Console.WriteLine("|| * 10.Show Link list                                       * ||");
            Console.WriteLine("|| * 0.Exit                                                  * ||");
            Console.WriteLine("|| ************************** End *****************************||");
            Console.WriteLine("=================================================================");
        }
    }

}
