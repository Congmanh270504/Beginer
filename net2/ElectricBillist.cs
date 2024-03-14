
namespace main2
{
    public class main
    {
        static void Main(string[] args)
        {
            electricBillist electrics = new electricBillist();
            electrics.AddList();
            electrics.checkSwap();
            Console.ReadKey();
        }
    }
    public class electricBill
    {
        private
        string id;
        string name;
        double sodiendauky, sodiencuoiky;
        char typeFamily;
        public electricBill(string id, string name, double sodiendauky, double sodiencuoiky, char typeFamily)
        {
            this.Id = id;
            this.Name = name;
            this.Sodiendauky = sodiendauky;
            this.Sodiencuoiky = sodiencuoiky;
            this.TypeFamily = typeFamily;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Sodiendauky { get => sodiendauky; set => sodiendauky = value; }
        public double Sodiencuoiky { get => sodiencuoiky; set => sodiencuoiky = value; }
        public char TypeFamily { get => typeFamily; set => typeFamily = value; }

        public void getInfor()
        {
            Console.WriteLine("Ma ho: " + Id);
            Console.WriteLine("Ten chu ho: " + Name);
            Console.WriteLine("So dien dau ky: " + Sodiendauky);
            Console.WriteLine("So dien cuoi ky: " + Sodiencuoiky);
            Console.WriteLine("Loai ho gia dinh: " + TypeFamily);
        }
        public double electricityConsumed()
        {
            return (double)sodiendauky - sodiencuoiky;
        }
        public double payElectricity()
        {
            if (typeFamily == 'A')
            {
                return (double)(electricityConsumed() - 10) * 3000;
            }
            else if (typeFamily == 'B')
            {
                return (double)(electricityConsumed() - 5) * 3000;
            }
            else
            {
                return (double)electricityConsumed() * 3000;
            }
        }

    }
    public class electricBillist
    {
        List<electricBill> electricBills = new List<electricBill>();

        public List<electricBill> ElectricBills { get => electricBills; set => electricBills = value; }
        public void AddList()
        {
            electricBills.Add(new electricBill("4312a", "Manh", 10, 50, 'A'));
            electricBills.Add(new electricBill("765B", "Son", 20, 70, 'B'));
            electricBills.Add(new electricBill("1234D", "Tan", 40, 80, 'A'));
            electricBills.Add(new electricBill("078C", "Quy", 35, 100, 'D'));
        }
        public void output()
        {
            if (electricBills == null)
            {
                AddList();
                foreach (var item in electricBills)
                {
                    item.getInfor();
                }
            }
            else
            {
                foreach (var item in electricBills)
                {
                    item.getInfor();
                }
            }

        }
        public void swap<T>(List<T> list,  int a,  int b)
        {
            T temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
        public void checkSwap()
        {
            swap(electricBills, 0, 1);// swap ko xai thg vao main dc
            output();
        }
       
    }
}