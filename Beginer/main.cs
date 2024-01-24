using System;
// crl R+ E shortcut get set atribute
namespace Beginer // Note: actual namespace depends on the project name.
{

    class main
    {
        static void Main(string[] args)
        {
            //Employee Manh = new Employee("12MA", "Cong Manh", 1.6, 2022);


            ////float a = Manh.allowancePoint(Manh.TimeWork);
            ////Console.WriteLine("Nam vao lam la: " + a);
            ////double b = Manh.allowancePoint(a);
            ////Console.WriteLine("He so phu cap tham nien la: " + b);



            //Manh.getInfor();

            //double result2 = Manh.getSalary();
            //Console.WriteLine("Luong co ban la: " + result2);


            //double result = Manh.allowancePoint();
            //Console.WriteLine("He so phu cap tham nien la: " + result);

            ElectricBill Manh = new ElectricBill("12MA", "Cong Manh", 150, 100, 'C');
            Manh.getInfor();
            Console.WriteLine("So dien tieu thu thuc te la: " + Manh.electricityConsumed());
            Console.WriteLine("Tien dien phai tra la: "+ Manh.payElectricity());

            Console.ReadKey();

        }
    }

}

