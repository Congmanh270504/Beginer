using System;

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
            int choose;
            Console.WriteLine("Nhap thong tin khach hang: ");
            Console.Write("Ten khach hang: ");
            string name = Console.ReadLine();
            Console.Write("ID khach hang: ");
            string id = Console.ReadLine();
            Console.Write("So tien trong tk: ");
            long money = System.Convert.ToInt64(Console.ReadLine());
            Bank Guest = new Bank(name, id, money);
            menu();
            do
            {
                Console.Write("Nhap phuong an: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.Write("Ban muon nhap bao nhieu: ");
                        int put = Convert.ToInt32(Console.ReadLine());
                        Guest.rechage(put);
                        break;
                    case 2:
                        Console.Write("Ban muon rut bao nhieu: ");
                        int take = Convert.ToInt32(Console.ReadLine());
                        if (Guest.money == 0 || Guest.money < money)
                        {
                            Console.WriteLine("Ban khong the thuc hien thao tac rut tien vi tk hien tai la " + Guest.money);
                        }
                        else
                        {
                            Guest.withdrawals(take);
                        }
                        break;
                    case 3:
                        Guest.checkAccount();
                        break;
                    case 0:
                        Console.WriteLine("Have a nice day Sir!!");
                        return;
                    default:
                        Console.WriteLine("Wrong choose!!");
                        break;
                }
            }
            while (choose != 0);
            Console.ReadKey();

        }
    }

}

