namespace Abstract
{
    
    public abstract class Subject
    {
        string id, name;
        int tc;
        public Subject(string id, string name, int tc)
        {
            this.id = id;
            this.name = name;
            this.tc = tc;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Tc { get => tc; set => tc = value; }
        public abstract double getAverageP();

        public void convertCharP()
        {
            var point = getAverageP();
            if (point < 4)
            {
                Console.WriteLine("F");
            }
            else if (point <= 4.9)
            {
                Console.WriteLine("D");
            }
            else if (point <= 5.4)
            {
                Console.WriteLine("D+");
            }
            else if (point <= 6.4)
            {
                Console.WriteLine("C");
            }
            else if (point <= 6.9)
            {
                Console.WriteLine("C+");

            }
            else if (point <= 7.9)
            {
                Console.WriteLine("B");

            }
            else if (point <= 8.4)
            {
                Console.WriteLine("B+");

            }
            else if (point <= 9.4)
            {
                Console.WriteLine("A");
            }
            else
            {
                Console.WriteLine("A+");
            }

        }
    }
     class Theory : Subject
    {
        double tl, ck;
        public Theory(string id, string name, int tc, double tl, double ck) : base(id, name, tc)
        {
            this.tl = tl;
            this.ck = ck;
        }
        public override double getAverageP()
        {
            return (double)tl * 0.3 + ck * 0.7;
        }
    }
     class Pratice : Subject
    {
        double ex1, ex2, ex3;
        public Pratice(string id, string name, int tc, double ex1, double ex2, double ex3) : base(id, name, tc)
        {
            this.ex1 = ex1;
            this.ex2 = ex2;
            this.ex3 = ex3;
        }
        public override double getAverageP()
        {
            return (double)(ex1 + ex2 + ex3) / 3;
        }
    }
     class Project : Subject
    {
        double gvhd, gvpb;
        public Project(string id, string name, int tc, double gvhd, double gvpb) : base(id, name, tc)
        {
            this.gvhd = gvhd;
            this.gvpb = gvpb;
        }
        public override double getAverageP()
        {
            return (double)(gvpb + gvhd) / 2;
        }
    }
}
