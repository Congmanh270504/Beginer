using System;
// crl R+ E shortcut get set atribute
namespace Beginer // Note: actual namespace depends on the project name.
{

    class Program
    {

        static void Main(string[] args)
        {
            EmployeeList employeeList = new EmployeeList();
            employeeList.Add(new Employee("4312a", "Manh", 1.0, 2013));
            employeeList.Add(new Employee("765B", "Son", 2.0, 2008));
            employeeList.Add(new Employee("078C", "Quy", 3.5, 2015));
            employeeList.Add(new Employee("1234D", "Tan", 4.0, 2018));

            //employeeList.getInfor();
            //employeeList.checkSalary();

            //Console.WriteLine("Nhan vien co tien luong cao nhat thang: ");
            //employeeList.indexOf(employeeList.getHighestSalary());
            employeeList.sortDateWorkIncrease();
            employeeList.getInfor();
            Console.WriteLine("Tong tien luong nhan vien: " + employeeList.getSumSalary());
            Console.WriteLine("Nhap ten nhan vien can tim: ");

            Console.ReadKey();

        }
    }

}

