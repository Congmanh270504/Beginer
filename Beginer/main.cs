using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginer
{
    internal class main
    {
        static void Main(string[] args)
        {
            mainStudent(args);
            // mainEmployee(args);
        }
        public static void mainStudent(string[] args)
        {
            Student_Generic list = new Student_Generic();
            list.Add(new Student("4312a", "Manh", 9.0));
            list.Add(new Student("765B", "Son", 8.0));
            list.Add(new Student("078C", "Quy", 7.5));
            list.Add(new Student("1234D", "Tan", 10));

            list.xuatDS();

            string a;
            int choose = 0;
            int choose2 = 0;
            do
            {
                list.menu();
                Console.Write("Nhap lua chon bai lam:");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        list.getGreater8();
                        break;
                    case 2:
                        list.menu2();
                        choose2 = int.Parse(Console.ReadLine());
                        switch (choose2)
                        {
                            case 1:
                                Console.Write("Nhap ten sinh vien can tim: ");
                                a = Console.ReadLine()!;
                                list.findStudentByName(a);
                                break;
                            case 2:
                                Console.Write("Nhap ma sinh vien can tim: ");
                                a = Console.ReadLine()!;
                                list.findStudentById(a);
                                break;
                            case 0:
                                Console.WriteLine("Oke!");
                                break;
                            default: break;
                        }
                        break;
                    case 0:
                        Console.WriteLine("Have a nice day!!");
                        break;
                    default:
                        Console.WriteLine("Khong co su lua chon do");
                        break;
                }
            }
            while (choose != 0);

            Console.ReadKey();

        }
        public static void mainEmployee(string[] args)
        {
            EmployeeList employeeList = new EmployeeList();
            employeeList.Add(new Employee("4312a", "Manh", 1.0, 2013));
            employeeList.Add(new Employee("765B", "Son", 2.0, 2008));
            employeeList.Add(new Employee("078C", "Quy", 3.5, 2015));
            employeeList.Add(new Employee("1234D", "Tan", 4.0, 2018));

            employeeList.getInfor();
            employeeList.checkSalary();

            Console.WriteLine("Nhan vien co tien luong cao nhat thang: ");
            employeeList.indexOf(employeeList.getHighestSalary());
            employeeList.sortDateWorkIncrease();
            employeeList.getInfor();
            Console.WriteLine("Tong tien luong nhan vien: " + employeeList.getSumSalary());
            Console.WriteLine("Nhap ten nhan vien can tim: ");

            Console.ReadKey();

        }

    }
}
