namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            phanso a = new phanso(1, 2);
            phanso b = new phanso(1, 2);
            phanso p = a + b;
            Console.WriteLine("{0}/{1}", p.Tu, p.Mau);
        }
    }
    public class phanso
    {
        int mau, tu;
        public int Mau { get => mau; set => mau = value; }
        public int Tu { get => tu; set => tu = value; }
        public phanso(int mau, int tu)
        {
            this.tu = tu;
            this.mau = mau;
        }
        public static phanso operator +(phanso a, phanso b)
        {
            phanso ps = new phanso(a.Tu * b.Mau, a.Mau * b.tu);
            return ps;
        }
    }

}
