using System.Xml.Linq;

namespace Interface
{
    class mainCoffee
    {
        public static void Main(string[] args)
        {
            GrainCoffee grainCoffee = new GrainCoffee("13DH", "Coffe Hat", 20, 23000);
            grainCoffee.getInfor();

            PureGrindCoffee pureGrindCoffee = new PureGrindCoffee("14DH", "Coffe xay nguyen chat", 30, 20000);
            pureGrindCoffee.getInfor();

            ScentGrindCoffee scentGrindCoffee = new ScentGrindCoffee("14DH", "Coffe huong lieu", 30, 25000, 15, 50000);
            scentGrindCoffee.getInfor();
            PackCoffee packCoffee = new PackCoffee("14DH", "Coffe goi", 30, 30000, "giay");
            packCoffee.getInfor();
            Console.ReadKey();

        }
    }
    abstract class Coffee
    {
        string id, name;
        int quantity;
        long bill;
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public long Bill { get => bill; set => bill = value; }

        public abstract double getCost();
        public abstract void getInfor();

    }

    interface ISupportEco
    {
        public double Sup();
    }
    interface IGrindCoffee
    {
        public double grindWage();
    }
    interface IBartending
    {
        public double bartenCost();
    }
    interface IPackCoffee
    {
        public double packPapper();
        public double packPlastic();
    }

    class GrainCoffee : Coffee, ISupportEco
    {
        public GrainCoffee(string id, string name, int quantity, long bill)
        {
            this.Id = id;
            this.Name = name;
            this.Quantity = quantity;
            this.Bill = bill;
        }
        public override double getCost()
        {
            return (double)(Quantity * Bill) - Sup();
        }
        public double Sup()
        {
            return (double)Quantity * 10;
        }
        public override void getInfor()
        {
            Console.WriteLine("\t--Grain Coffee--");
            double check = getCost();
            Console.WriteLine("Id:{0}\nName:{1}\nQuantiny:{2}\nBill:{3}\nCost:{4} ", Id, Name, Quantity, Bill, getCost());
        }

    }

    class PureGrindCoffee : Coffee, ISupportEco, IGrindCoffee
    {

        public PureGrindCoffee(string id, string name, int quantity, long bill)
        {
            this.Id = id;
            this.Name = name;
            this.Quantity = quantity;
            this.Bill = bill;
        }
        public override double getCost()
        {
            return (double)Quantity * Bill + grindWage();
        }
        public double grindWage()
        {
            if (Quantity < 100)
            {
                return 100 * Quantity;
            }
            else
            {
                return 95 * Quantity;
            }
        }
        public double Sup()
        {
            return Quantity * 12;
        }
        public override void getInfor()
        {
            Console.WriteLine("\t--Pure Grind Coffee--");
            Console.WriteLine("Id:{0}\nName:{1}\nQuantiny:{2}\nBill:{3}\nCost:{4} ", Id, Name, Quantity, Bill, getCost());
        }
    }
    class ScentGrindCoffee : Coffee, IBartending
    {
        int quantityScent;
        long costScent;
        public ScentGrindCoffee(string id, string name, int quantity, long bill, int quantityScent, long costScent)
        {
            this.Id = id;
            this.Name = name;
            this.Quantity = quantity;
            this.Bill = bill;
            this.quantityScent = quantityScent;
            this.costScent = costScent;
        }

        public override double getCost()
        {
            return (double)Quantity * Bill + quantityScent * costScent + bartenCost();
        }
        public double bartenCost()
        {
            return Quantity * 2;
        }
        public override void getInfor()
        {
            Console.WriteLine("\t--Scent Grind Coffee-- ");
            Console.WriteLine("Id:{0}\nName:{1}\nQuantiny:{2}\nBill:{3}\nCost:{4} ", Id, Name, Quantity, Bill, getCost());
        }
    }
    class PackCoffee : Coffee
    {
        string material;
        public PackCoffee(string id, string name, int quantity, long bill, string material)
        {
            this.Id = id;
            this.Name = name;
            this.Quantity = quantity;
            this.Bill = bill;
            this.material = material;
        }

        public string Material { get => material; set => material = value; }

        public double packPapper()
        {
            return Quantity * Bill * 110 / 100;
        }
        public double packPlastic()
        {
            return Quantity * Bill * 120 / 100;
        }
        public override double getCost()
        {
            if (Material.Equals("giay"))
            {
                return packPapper();
            }
            else
            {
                return packPlastic();
            }
        }

        public override void getInfor()
        {
            Console.WriteLine("\t--Pack Coffee-- ");
            Console.WriteLine("Id:{0}\nName:{1}\nQuantiny:{2}\nBill:{3}\nCost:{4} ", Id, Name, Quantity, Bill, getCost());
        }
    }
}
