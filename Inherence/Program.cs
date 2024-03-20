//namespace Inherence
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            External thanhbuoi = new External();
//            thanhbuoi.output();
//            Console.ReadLine();
//        }
//    }
//    public class car
//    {
//        string id, name;
//        long distance, income;

//        public car()
//        {
//            id = "";
//            name = "";
//            distance = 0;
//            income = 0;
//        }

//        public car(string id, string name, long distance, long income)
//        {
//            this.Id = id;
//            this.Name = name;
//            this.Distance = distance;
//            this.Income = income;
//        }

//        public string Id { get => id; set => id = value; }
//        public string Name { get => name; set => name = value; }
//        public long Distance { get => distance; set => distance = value; }
//        public long Income { get => income; set => income = value; }
//        public void input()
//        {
//            Console.Write("Nhap id xe: ");
//            this.id = Console.ReadLine();
//            Console.Write("Nhap Ten xe: ");
//            this.name = Console.ReadLine();

//            Console.Write("Nhap quang duong xe di: ");
//            this.distance = Convert.ToInt64(Console.ReadLine());

//            Console.Write("Nhap So tuyen xe: ");
//            this.income = Convert.ToInt64(Console.ReadLine());

//        }
//        public void output()
//        {
//            Console.WriteLine("Id xe: " + this.id);
//            Console.WriteLine("Ma xe: " + this.Name);
//            Console.WriteLine("Quang duong xe chay: " + this.distance);
//            Console.WriteLine("Doanh thu: " + this.income);
//        }
//    }
//    public class Internal : car
//    {
//        string id, name;
//        long distance, income;
//        int carnumber, route;
//        public Internal(string id, string name, int carnumber, int route, long distance, long income) : base(id, name, distance, income)
//        {
//            this.Carnumber = carnumber;
//            this.Route = route;

//        }
//        public Internal() : base()
//        {
//            this.Carnumber = 0;
//            this.Route = 0;

//        }
//        public int Carnumber { get => carnumber; set => carnumber = value; }
//        public int Route { get => route; set => route = value; }

//        public new void input()
//        {
//            base.input();
//            Console.Write("Nhap Ma so xe: ");
//            this.carnumber = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Nhap So tuyen xe: ");
//            this.route = Convert.ToInt32(Console.ReadLine());
//        }
//        public new void output()
//        {
//            base.output();
//            Console.WriteLine("So xe: " + this.carnumber);
//            Console.WriteLine("Tuyen xe: " + this.route);
//        }
//    }
//    public class External : car
//    {
//        string id, destination, name;
//        long distance, income;
//        int day;

//        public string Destination { get => destination; set => destination = value; }
//        public int Day { get => day; set => day = value; }

//        public External(string id, string name, string destination, int day, long distance, long income) : base(id, name, distance, income)
//        {
//            this.Destination = destination;
//            this.Day = day;
//        }
//        public External() : base()
//        {
//            this.destination = "";
//            this.day = 0;

//        }


//        public new void input()
//        {
//            base.input();
//            Console.Write("Nhap Ma so xe: ");
//            this.destination = Console.ReadLine();
//            Console.Write("Nhap So tuyen xe: ");
//            this.day = Convert.ToInt32(Console.ReadLine());
//        }
//        public new void output()
//        {
//            base.output();
//            Console.WriteLine("So xe: " + this.destination);
//            Console.WriteLine("Tuyen xe: " + this.day);
//        }
//    }
//}
