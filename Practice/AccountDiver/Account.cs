using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            status = "";
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
    }

}
