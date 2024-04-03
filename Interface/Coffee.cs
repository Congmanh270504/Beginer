namespace Interface
{
    class mainCoffee
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
    }
    class PackCoffee : Coffee
    {
        public override double getCost()
        {
            return 0;
        }
    }
}
