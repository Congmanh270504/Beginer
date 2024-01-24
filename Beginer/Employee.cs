using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginer
{
    internal class Employee
    {
        private
        const long MLTT = 1490000;
        string id;
        string name;
        double salaryPoint;
        int timeWork;
        long salary;
        public Employee(string id, string name, double salaryPoint, int timeWork)
        {
            this.id = id;
            this.name = name;
            this.salaryPoint = salaryPoint;
            this.timeWork = timeWork;
        }

        public double allowancePoint()
        {
            return (double)(2024 - timeWork) / 100;
        }
        public double getSalary()
        {
            return (double) salaryPoint * MLTT;
        }
        public void getInfor()
        {
            Console.WriteLine("Ma nhan vien: " + id);
            Console.WriteLine("Ten nhan vien: " + name);
            Console.WriteLine("He so luong: " + salaryPoint);
            Console.WriteLine("Thoi gian vao lam: " + timeWork);
        }
    }
}
