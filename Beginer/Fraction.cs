using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginer
{
    internal class Fraction
    {
       public int tu, mau;
       public Fraction(int x, int y)
        {
            this.tu = x;
            this.mau = y;
        }
        public Fraction Plus(Fraction b)
        {
            this.tu = this.tu * b.mau + b.tu * this.mau;
            this.mau = this.mau * b.mau;
            return this;
        }
        public Fraction Plus(int b)
        {
            this.tu = this.tu+ b* this.mau;
            return this;
        }
    }
}
