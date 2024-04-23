using System.Xml.Linq;

namespace Interface
{
    class mainCoffee
    {
        public static void Main(string[] args)
        {
            CoffeeBeans coffeBeans = new CoffeeBeans("13DH", "Coffe Hat", 20, 23000);
            coffeBeans.getInfor();

            NaturalCoffee naturalCoffe = new NaturalCoffee("14DH", "Coffe xay nguyen chat", 30, 20000);
            naturalCoffe.getInfor();

            FlavorCoffee flavorCoffe = new FlavorCoffee("14DH", "Coffe huong lieu", 30, 25000, 15, 50000);
            flavorCoffe.getInfor();
            PackCoffee packCoffe = new PackCoffee("14DH", "Coffe goi", 30, 30000, "giay");
            packCoffe.getInfor();
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

        public Coffee(string id, string name, int quantity, long bill)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.bill = bill;
        }

        public double getCost()
        {
            return Quantity * Bill;
        }
        public abstract double getCostItem();
        public abstract void getInfor();
    }

    interface ISupportEco
    {
        public double Sup();
    }
    class CoffeeBeans : Coffee, ISupportEco
    {
        public CoffeeBeans(string id, string name, int quantity, long bill) : base(id, name, quantity, bill)
        {
        }
        public override double getCostItem()
        {
            return getCost() - Sup();
        }
        public double Sup()
        {
            return Quantity * 10;
        }
        public override void getInfor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t--Coffee Beans--");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\tId:{0}\n\tName:{1}\n\tQuantiny:{2}\n\tBill:{3}\n\tCost:{4}", Id, Name, Quantity, Bill, getCost());
        }
    }
    class NaturalCoffee : Coffee, ISupportEco
    {
        public NaturalCoffee(string id, string name, int quantity, long bill) : base(id, name, quantity, bill)
        {

        }
        public int congxay()
        {
            if (Quantity < 100)
            {
                return 100 * Quantity;
            }
            return 95 * Quantity;
        }
        public override double getCostItem()
        {
            return getCost() + congxay() - Sup();
        }
        public double Sup()
        {
            return Quantity * 12;
        }
        public override void getInfor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t--Natural Coffee--");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\tId:{0}\n\tName:{1}\n\tQuantiny:{2}\n\tBill:{3}\n\tCost:{4}", Id, Name, Quantity, Bill, getCost());
        }
    }
    class FlavorCoffee : Coffee
    {
        int flavor_quantity;
        long flavor_bill;
        public FlavorCoffee(string id, string name, int quantity, long bill, int flavor_quantity, long flavor_bill) : base(id, name, quantity, bill)
        {
            this.flavor_quantity = flavor_quantity;
            this.flavor_bill = flavor_bill;
        }

        public override double getCostItem()
        {
            return getCost() + flavor_bill * flavor_quantity + Quantity * 2;
        }
        public override void getInfor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t--Flavor Coffee-- ");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\tId:{0}\n\tName:{1}\n\tQuantiny:{2}\n\tBill:{3}\n\tCost:{4}", Id, Name, Quantity, Bill, getCost());
        }
    }
    class PackCoffee : Coffee
    {
        string material;
        public PackCoffee(string id, string name, int quantity, long bill, string material) : base(id, name, quantity, bill)
        {
            this.material = material;
        }

        public string Material
        {

            get
            {
                if (!material.Equals("giay") || !material.Equals("nhua"))
                {
                    throw new Exception("Material just: 1.giay 2.nhua!!");
                }
                else
                {
                    return material;
                }
            }
            set
            {
                material = value;
            }
        }
        public override double getCostItem()
        {
            if (Material.Equals("giay"))
            {
                return getCost() * 1.1;
            }
            else
            {
                return getCost() * 1.2;
            }
        }
        public override void getInfor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t--Pack Coffee-- ");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\tId:{0}\n\tName:{1}\n\tQuantiny:{2}\n\tMaterial:{3}\n\tBill:{4}\n\tCost:{4} ", Id, Name, Material, Quantity, Bill, getCost());
        }
    }

}
