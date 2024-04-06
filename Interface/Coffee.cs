using System.Xml.Linq;

namespace Interface
{
    class mainCoffee
    {
        public static void Main(string[] args)
        {
            GrainCoffee grainCoffee = new GrainCoffee();
            grainCoffee.setInfor();
            grainCoffee.getInfor();

            PureGrindCoffee pureGrindCoffee = new PureGrindCoffee();
            pureGrindCoffee.setInfor();
            pureGrindCoffee.getInfor();
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
        public abstract void setInfor();
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
        public override double getCost()
        {
            return (double)(Quantity * Bill) - Sup();
        }
        public double Sup()
        {
            return (double)Quantity * 10;
        }
        public override void setInfor()
        {
            Console.WriteLine("--Grain Coffee--");
            Console.Write("ID:");
            string id = Console.ReadLine();
            Id = id;
            Console.Write("Name:");
            string name = Console.ReadLine();
            Name = name;
            Console.Write("So luong:");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Quantity = quantity;
            Console.Write("Gia tien:");
            long bill = Convert.ToInt64(Console.ReadLine());
            Bill = bill;
        }
        public override void getInfor()
        {
            Console.WriteLine("--Grain Coffee--");
            double check = getCost();
            Console.WriteLine("Id:{0}\nName:{1}\nQuantiny:{2}\nBill:{3}\nCost:{4} ", Id, Name, Quantity, Bill, getCost());
        }

    }

    class PureGrindCoffee : Coffee, ISupportEco, IGrindCoffee
    {
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
        public override void setInfor()
        {
            Console.WriteLine("--Pure Grind Coffee--");
            Console.Write("ID:");
            string id = Console.ReadLine();
            Id = id;
            Console.Write("Name:");
            string name = Console.ReadLine();
            Name = name;
            Console.Write("Quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Quantity = quantity;
            Console.Write("Bill:");
            long bill = Convert.ToInt64(Console.ReadLine());
            Bill = bill;
        }
        public override void getInfor()
        {
            Console.WriteLine("Pure Grind Coffee ");
            Console.WriteLine("Id:{0}\nName:{1}\nQuantiny:{2}\nBill:{3}\nCost:{4} ", Id, Name, Quantity, Bill, getCost());
        }
    }
    class ScentGrindCoffee : Coffee, IBartending
    {
        int quantityScent;
        long costScent;
        public override double getCost()
        {
            return (double)Quantity * Bill + quantityScent * costScent + bartenCost();
        }
        public double bartenCost()
        {
            return Quantity * 2;
        }
        public override void setInfor()
        {
            Console.WriteLine("");
        }
        public override void getInfor()
        {
        }
    }
    class PackCoffee : Coffee
    {
        string material;

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
        public override void setInfor()
        {
            Console.WriteLine("");
        }
        public override void getInfor()
        {
        }
    }
}
