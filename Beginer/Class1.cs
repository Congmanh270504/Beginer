using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginer
{
    internal class Class1
    {
        public int b { get; set; }
        int c;

        int d;

        static int a; static string name;
        static Class1()
        {
            a = 0;
            name = null;
        }
        public Class1()
        {
            b = 7;
        }
        public int A
        {
            get
            {
                return a;
            }
            set { a = value; }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set { name = value; }
        }

        public int C { get => c; set => c = value; }
        public int D { get => d; set => d = value; }

        public void DemDungHam()
        {
            int count = 0;
            Console.WriteLine(count.ToString());
            count++;
        }



        public void call()
        {
            DemDungHam();
            DemDungHam();
            DemDungHam();
            DemDungHam();
            DemDungHam();
            DemDungHam();
            DemDungHam();
        }
    }
}
