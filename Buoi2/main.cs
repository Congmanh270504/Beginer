using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class main
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            mainStudent(args);
            Console.ReadKey();
        }
        static void mainTeacher(string[] args)
        {
            string file = "../../Teacher.xml";
            ListTeacher listTeacher = new ListTeacher();
            listTeacher.Input(file);
            listTeacher.sortGroup();
            listTeacher.Output();
        }
        static void mainStudent(string[] args)
        {
            string file = "../../Bai2/Student.xml";
            ListStudent listStudent = new ListStudent();
            List<Student> a;
            listStudent.Input(file);
            int choose = 0;
            do
            {
                choose = Convert.ToInt32(Console.ReadKey());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Danh sach sinh vien:");
                        break;
                    case 2:
                        Console.WriteLine("Danh sach sinh vien:");
                        listStudent.Output();
                        break;
                    case 3:
                        a = listStudent.sortPoint();
                        foreach (var item in a)
                        {
                            item.getInfor();
                        }
                        break;
                    case 4:
                        a = listStudent.sortName();
                        foreach (var item in a)
                        {
                            item.getInfor();
                        }
                        break;
                    case 5:
                        a = listStudent.sortName();
                        foreach (var item in a)
                        {
                            item.getInfor();
                        }
                        break;
                    case 6:
                        a = listStudent.getInforPassed();
                        foreach (var item in a)
                        {
                            item.getInfor();
                        }
                        break;
                    case 7:
                        a = listStudent.getInforDayBorn();
                        foreach (var item in a)
                        {
                            item.getInfor();
                        }
                        break;
                    case 0:
                        Console.WriteLine("\tHave a nice day sir!!\n");
                        break;
                        break;
                    default:
                        Console.WriteLine("Don't have that choose!!\n");
                        break;
                }
            } while (choose != 0);


            //listStudent.sortName();
           
            a = listStudent.getInforDayBorn();
            foreach (var item in a)
            {
                item.getInfor();
            }
        }
        static void mainStaff()
        {
            string file = "../../Staff.xml";
            ListStaff listStaff = new ListStaff();
            List<Staff> a;
            listStaff.Input(file);
            listStaff.Output();
        }
    }
}
