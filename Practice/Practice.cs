namespace Practice
{
    internal class Practice
    {
        static void Main(string[] args)
        {
            Console.ReadKey();

        }
    }
    abstract class ContractSinger
    {
        string id, name;
        int numberRepertoire;
        DateTime datestart;
        double bill, surchange;
       public  static double taxpoint = 0.15;

        public string Id { get => id; set => id = value; }
        public double Bill { get => bill; set => bill = value; }
        public string Name { get => name; set => name = value; }
        public int NumberRepertoire { get => numberRepertoire; set => numberRepertoire = value; }
        public double Surchange { get => surchange; set => surchange = value; }

        public ContractSinger()
        {
            this.id = "HD3418";
            this.name = "Ly Khong Hay";
            this.NumberRepertoire = 3;
            this.datestart = new DateTime(2020, 10, 24);
            this.bill = 4000000;
            this.Surchange = 2000000;
        }
        public void checkName()
        {
            if (!this.id.StartsWith("HD"))
            {
                throw new Exception("Error Id name !!");
            }
            else
            {
                for (int i = 2; i < name.Length; i++)
                {
                    if (!(this.name[i] > '0' && this.name[i] < '9'))
                    {
                        throw new Exception("Error Id name !!");
                    }
                }
            }
        }
      

        public ContractSinger(string id, string name, double bill)
        {
            this.id = id;
            this.name = name;
            this.NumberRepertoire = 2;
            this.datestart = new DateTime(2020, 10, 24);
            this.bill = bill;
            this.Surchange = 0;
        }
        public double getCost()
        {
            return Bill * NumberRepertoire + Surchange;
        }
        public abstract double entertamentCost();
    }
    class AtHome : ContractSinger
    {
        int distance;
        AtHome(int distance) : base()
        {
            this.distance = distance;
        }
        public override double entertamentCost()
        {
            if (this.distance < 20)
            {
                return getCost() + this.distance * 400000;
            }
            else
            {
                if (this.distance * 300000 > 15000000)
                {
                    return 0;
                }
                return getCost() + this.distance * 300000;
            }
        }
        

    }
    class SmallStadium : ContractSinger
    {
        int scale;
        SmallStadium(int scale) : base()
        {
            this.scale = scale;
        }
        public override double entertamentCost()
        {
            return getCost() + 10000000 + 2000000 * NumberRepertoire;
        }
        
    }
    class LargeStadium : ContractSinger
    {
        int audiences;
        LargeStadium(int audiences) : base()
        {
            this.audiences = audiences;
        }
        public override double entertamentCost()
        {
            if (this.audiences < 1000000)
            {
                return getCost() + 30000000;
            }
            else
            {
                return getCost() + 50000000;
            }
        }
        
    }
}
