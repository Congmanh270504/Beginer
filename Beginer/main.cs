using System;
// crl R+ E shortcut get set atribute
namespace Beginer // Note: actual namespace depends on the project name.
{

    class Program
    {

        static void Main(string[] args)
        {
            ////Student_Generic First = new Student_Generic();
            //Student_Generic list = new Student_Generic();

            //list.Add(new Student("4312a", "Manh", 9.0));
            //list.Add(new Student("765B", "Son", 8.0));
            //list.Add(new Student("078C", "Quy", 7.5));
            //list.Add(new Student("1234D", "Tan", 10));

            //list.xuatDS();

            //list.getGreater8();

            //Console.Write("Nhap ten sinh vien can tim: ");
            //string a = Console.ReadLine()!;
            //list.findStudentByName(a);

            //Console.Write("Nhap ma sinh vien can tim: ");
            //a = Console.ReadLine()!;
            //list.findStudentById(a);
            //int choose = 0;
            //do
            //{
            //    Console.WriteLine("Nhap lua chon bai lam:");
            //    choose = int.Parse(Console.ReadLine());
            //    switch (choose)
            //    {
            //        case 1:
            //            break;
            //        case 2:
            //            break;
            //        default:
            //            Console.WriteLine("Khong co su lua chon do");
            //            break;
            //    }
            //}
            //while (choose != 0);





            EmployeeList employeeList = new EmployeeList();
            employeeList.Add(new Employee("4312a", "Manh", 9.0, 2012));
            employeeList.Add(new Employee("765B", "Son", 8.0, 2013));
            employeeList.Add(new Employee("078C", "Quy", 7.5, 2015));
            employeeList.Add(new Employee("1234D", "Tan", 10, 2014));

            employeeList.getInfor();
            Console.WriteLine("Tong tien luong nhan vien: " + employeeList.getSumSalary());
            Console.WriteLine("Nhap ten nhan vien can tim: ");
            
            Console.ReadKey();

        }
    }

}

