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
            return a.Next(100);
        }
        public static void menu()
        {
            Console.WriteLine("============================= Menu ==============================");
            Console.WriteLine("|| ************************** Init ****************************||");
            Console.WriteLine("|| * 1.Show Cutomer list                                     * ||");
            Console.WriteLine("|| * 2.Show Diver list                                       * ||");
            Console.WriteLine("|| ************************** Pratice ************************ ||");
            Console.WriteLine("|| * 3.Count in total vehical                                * ||");
            Console.WriteLine("|| * 4.Count total customer                                  * ||");
            Console.WriteLine("|| * 5.Get all Revenue each type vehicle                     * ||");
            Console.WriteLine("|| * 6.Get highest cost motobike                             * ||");
            Console.WriteLine("|| * 7.Get highest cost car                                  * ||");
            Console.WriteLine("|| * 8.Get highest cost truck                                * ||");
            Console.WriteLine("|| * 9.Sort driver by cost                                   * ||");
            Console.WriteLine("|| * 10.Get VIP customer                                     * ||");
            Console.WriteLine("|| * 11.Get most Time Call customer                          * ||");
            Console.WriteLine("|| * 12.Get highest revenue driver (car/truck)               * ||");
            Console.WriteLine("|| * 13.Get infor car driver have bonus                      * ||");
            Console.WriteLine("|| * 14.Get infor truck driver have bonus                    * ||");
            Console.WriteLine("|| ************************** WriteFile ***********************||");
            Console.WriteLine("|| * 10.Show Link list                                       * ||");
            Console.WriteLine("|| * 0.Exit                                                  * ||");
            Console.WriteLine("|| ************************** End *****************************||");
            Console.WriteLine("=================================================================");
        }
    }

}
