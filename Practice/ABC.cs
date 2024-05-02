using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginer
{
    abstract class ABC
    {
        string name, id, place, degree;
        int error;

        double salarypoint;
        public static long basesalary = 1500000;
        public int Error
        {
            get { return error; }
            set { error = value; }
        }
        public string Place
        {
            get
            {
                if (!place.Equals("Viet Nam") && !place.Equals("Nuoc nguoi"))
                {
                    throw new Exception("Loi~ noi dao tao!!");
                }
                return place;
            }
            set { place = value; }
        }

        public ABC()
        {
            id = "";
            name = "";
            degree = "";
            place = "Viet nam";
            salarypoint = 0;
            error = 0;
        }
        public ABC(string id, string name, string degree, string place, double salarypoint, int error)
        {
            this.id = id;
            this.name = name;
            this.degree = degree;
            this.place = place;
            this.salarypoint = salarypoint;
            this.error = error;
        }
        public abstract double bonus();
        public double getSalary()
        {
            return salarypoint * basesalary + bonus();
        }
        public virtual double realSalary()
        {
            return getSalary();
        }
        public virtual void getInfor()
        {
            Console.WriteLine("Name:{0} Id:{1} Degree:{2} Place:{3} Salary Point:{4} Error:{5}");
        }
    }
}
