using System.IO;
namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            phanso a = new phanso(1, 2);
            phanso b = new phanso(1, 2);
            phanso p = a * b;
            phanso c = 2;
            //var q = phanso.Equals(a, b);
            //int e = (int)c;
            //Console.WriteLine("{0}/{1}", c.Tu, c.Mau);
            Console.WriteLine(q);
            //Console.WriteLine("{0}/{1}", p.Tu, p.Mau);
        }
    }
    public class phanso
    {
        int mau, tu;
        public int Mau { get => mau; set => mau = value; }
        public int Tu { get => tu; set => tu = value; }
        public phanso(int tu, int mau)
        {
            if (mau == 0)
            {
                throw new Exception("Can't devide zero!");
            }
            this.tu = tu;
            this.mau = mau;
        }
        public static phanso operator +(phanso a) => a;
        public static phanso operator -(phanso a) => new phanso(-a.Tu, a.Mau);

        public static phanso operator +(phanso a, phanso b) => new phanso(a.Tu * b.Mau + b.Tu * a.Mau, a.Mau * b.Mau);
        public static phanso operator -(phanso a, phanso b) => new phanso(a.Tu * b.Mau - b.Tu * a.Mau, a.Mau * b.Mau);
        public static phanso operator *(phanso a, phanso b) => new phanso(a.Tu * b.Tu, a.Mau * b.Mau);
        public static phanso operator /(phanso a, phanso b) => new phanso(a.Tu * b.Mau, a.Mau * b.Tu);

        public static bool Equals(phanso a, phanso b)
        {
            double equals1 = a.Tu / a.Mau;
            double equals2 = b.Tu / b.Mau;
            if (equals1 != equals2)
            {
                return false;
            }
            return true;
        }

        public static implicit operator phanso(int a)
        {
            return new phanso(a, 1);
        }
        public static explicit operator int(phanso a)
        {
            return a.Tu / a.Mau;
        }
    }

}
