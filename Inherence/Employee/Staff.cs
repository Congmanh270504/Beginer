using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inherence.Employee
{
    public class Staff
    {
        long HSL = 1000;

        string id, name, rank;
        int daywork, room;
        long salary;
        double conpetition;

        public Staff(string id, string name, int daywork, int room)
        {
            this.id = id;
            this.name = name;
            this.daywork = daywork;
            this.room = room;
        }
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public int Daywork { get => daywork; set => daywork = value; }
        public double Conpetition { get => conpetition; set => conpetition = value; }

        public string Race()
        {
            if (daywork > 25)
            {
                return "A";
            }
            else if (daywork > 22)
            {
                return "B";
            }
            else
            {
                return "C";
            }
        }
        public double getCompetition()
        {
            if (Race().Equals("A"))
            {
                return 1;
            }
            else if (Race().Equals("B"))
            {
                return 0.75;
            }
            else
            {
                return 0.5;
            }
        }
        public virtual long getSalary()
        {
            return Convert.ToInt64(1210 * getCompetition() * HSL);
        }

        public void getInfor()
        {
            Console.WriteLine("Ma nhan vien: " + id);
            Console.WriteLine("Ten nhan vien: " + name);
            Console.WriteLine("Thoi gian vao lam: " + daywork);
            Console.WriteLine("Luong: " + getSalary());
        }
    }
    public class Manager : Staff
    {
        string position;
        double factor;
        public Manager(string id, string name, int daywork, int room, string position, double factor) : base(id, name, daywork, room)
        {
            this.position = position;
            this.factor = factor;
        }
        public string Position { get => position; set => position = value; }
        public double Factor { get => factor; set => factor = value; }

        public override long getSalary()
        {
            return Convert.ToInt64(base.getSalary() + 1100 * factor);
        }
        public void getInfor()
        {
            
            base.getInfor();
            Console.WriteLine("Chuc vu: " + position);
            Console.WriteLine("He so chuc vu: " + factor);
        }

    }
}
