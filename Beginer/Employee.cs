using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginer
{
    public class Employee
    {
        private
        static long MLTT = 1500000;
        string id;
        string name;
        double salaryPoint;

        int timeWork;
        long salary;

        public Employee(string id, string name, double salaryPoint, int timework)
        {
            this.id = id;
            this.name = name;
            this.salaryPoint = salaryPoint;
            this.timeWork = timework;
        }
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public int TimeWork { get => timeWork; set => timeWork = value; }
        public double SalaryPoint { get => salaryPoint; set => salaryPoint = value; }
        public static double allowancePoint(int timeWork)
        {
            return (double)(DateTime.Now.Year - timeWork) / 100;
        }
        public double basicSalary()
        {
            return (double)SalaryPoint * MLTT;
        }
        public double getSalary()
        {
            return allowancePoint(timeWork) * basicSalary();
        }
        public void getInfor()
        {
            Console.WriteLine("Ma nhan vien: " + id);
            Console.WriteLine("Ten nhan vien: " + name);
            Console.WriteLine("He so luong: " + salaryPoint);
            Console.WriteLine("Thoi gian vao lam: " + timeWork + "\n");
        }
    }
    public class EmployeeList
    {
        List<Employee> employees = new List<Employee>();
        public List<Employee> Employees { get => employees; set => employees = value; }

        public void Add(Employee employee)
        {
            employees.Add(employee);
        }
        public void getInfor()
        {
            foreach (var item in employees)
            {
                item.getInfor();
            }
        }
        public double getSumSalary()
        {
            double sum = 0;
            foreach (var item in employees)
            {
                Console.WriteLine(item.getSalary());

            }
            foreach (var item in employees)
            {
                sum += item.getSalary();
            }
            return (double)sum;
        }
        public void findName(string name)
        {
            foreach (var item in employees)
            {
                if (item.Name.Equals(name))
                {
                    item.getInfor();
                }
            }
        }
    }
}
