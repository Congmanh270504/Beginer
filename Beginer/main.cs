using System;
// crl R+ E shortcut get set atribute
namespace Beginer // Note: actual namespace depends on the project name.
{

    class main
    {
        public static void menu()
        {
            Console.WriteLine("1.Nap tien");
            Console.WriteLine("2.Rut tien");
            Console.WriteLine("3.Kiem tra tai khoan");
            Console.WriteLine("0.Thoat chuong trinh");
        }
        static void Main(string[] args)
        {
            //int choose;
            //Console.WriteLine("Nhap thong tin khach hang: ");
            //Console.Write("Ten khach hang: ");
            //string name = Console.ReadLine();
            //Console.Write("ID khach hang: ");
            //string id = Console.ReadLine();
            //Console.Write("So tien trong tk: ");
            //long money = System.Convert.ToInt64(Console.ReadLine());
            //Bank Guest = new Bank(name, id, money);
            //menu();
            //do
            //{
            //    Console.Write("Nhap phuong an: ");
            //    choose = Convert.ToInt32(Console.ReadLine());
            //    switch (choose)
            //    {
            //        case 1:
            //            Console.Write("Ban muon nhap bao nhieu: ");
            //            int put = Convert.ToInt32(Console.ReadLine());
            //            Guest.rechage(put);
            //            break;
            //        case 2:
            //            Console.Write("Ban muon rut bao nhieu: ");
            //            int take = Convert.ToInt32(Console.ReadLine());
            //            if (Guest.money == 0 || Guest.money < money)
            //            {
            //                Console.WriteLine("Ban khong the thuc hien thao tac rut tien vi tk hien tai la " + Guest.money);
            //            }
            //            else
            //            {
            //                Guest.withdrawals(take);
            //            }
            //            break;
            //        case 3:
            //            Guest.checkAccount();
            //            break;
            //        case 0:
            //            Console.WriteLine("Have a nice day Sir!!");
            //            return;
            //        default:
            //            Console.WriteLine("Wrong choose!!");
            //            break;
            //    }
            //}
            //while (choose != 0);

            //Console.Write("Nhap tung do Ax: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Nhap hoanh do Ay: ");
            //int y = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Nhap tung do Bx: ");
            //int o = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Nhap hoanh do By: ");
            //int z = Convert.ToInt32(Console.ReadLine());


            //Oxy a = new Oxy(x, y);
            //Oxy b = new Oxy(o, z);
            //double result = Math.Round(a.getDistances(x, y), 4);
            //Console.WriteLine("Khoang cach tu goc toa do den diem A({0},{1}) la: {2}", x, y, result);
            //double answer = Math.Round(a.getA_B(b), 4);
            //Console.WriteLine("Khoang cach giua 2 diem AB la: {0}", answer);

            //Fraction a = new(2, 3);
            //int b = 4;
            //Fraction temp = a.Plus(a);
            //Console.WriteLine("Tu: {0} Mau:{1}", temp.tu, temp.mau);
            //Console.WriteLine("Tu: {0} Mau:{1}", a.tu, a.mau);
            //a.tu = 2;
            //a.mau = 3;
            //a.Plus(b);
            //Console.WriteLine("Tu: {0} Mau:{1}", a.tu, a.mau);
            Class1 a = new Class1();
            a.A = 1;
            //Console.WriteLine("{0}", a.A);

            a.call();

            Console.ReadKey();

        }
    }

}

