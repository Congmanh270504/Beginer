using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginer
{
    internal class Oxy
    {
        private int x, y;

        public Oxy(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double getDistances(int x, int y)
        {
            return (double)Math.Sqrt(x * x + y * y);
        }
        public double getA_B(Oxy b)
        {
            return (double)Math.Sqrt(Math.Pow(b.x - this.x, 2) + Math.Pow(b.y - this.y, 2));
        }
        ~Oxy()
        {
            Console.WriteLine("Delete Class Oxy");
        }
    }
}
