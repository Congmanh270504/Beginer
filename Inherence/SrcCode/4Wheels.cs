namespace Inherence.Employee
{

    public class Car
    {
        string id, name;
        long distance, income;

        public Car()
        {
            id = "";
            name = "";
            distance = 0;
            income = 0;
        }

        public Car(string id, string name, long distance, long income)
        {
            Id = id;
            Name = name;
            Distance = distance;
            Income = income;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public long Distance { get => distance; set => distance = value; }
        public long Income { get => income; set => income = value; }
        public void input()
        {
            Console.Write("Nhap id xe: ");
            id = Console.ReadLine();
            Console.Write("Nhap Ten xe: ");
            name = Console.ReadLine();

            Console.Write("Nhap quang duong xe di: ");
            distance = Convert.ToInt64(Console.ReadLine());

            Console.Write("Nhap So tuyen xe: ");
            income = Convert.ToInt64(Console.ReadLine());

        }
        public void output()
        {
            Console.WriteLine("Id xe: " + id);
            Console.WriteLine("Ma xe: " + Name);
            Console.WriteLine("Quang duong xe chay: " + distance);
            Console.WriteLine("Doanh thu: " + income);
        }
    }
    public class Internal : Car
    {
        string id, name;
        long distance, income;
        int carnumber, route;
        public Internal(string id, string name, int carnumber, int route, long distance, long income) : base(id, name, distance, income)
        {
            Carnumber = carnumber;
            Route = route;

        }
        public Internal() : base()
        {
            Carnumber = 0;
            Route = 0;

        }
        public int Carnumber { get => carnumber; set => carnumber = value; }
        public int Route { get => route; set => route = value; }

        public new void input()
        {
            base.input();
            Console.Write("Nhap Ma so xe: ");
            carnumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap So tuyen xe: ");
            route = Convert.ToInt32(Console.ReadLine());
        }
        public new void output()
        {
            base.output();
            Console.WriteLine("So xe: " + carnumber);
            Console.WriteLine("Tuyen xe: " + route);
        }
    }
    public class External : Car
    {
        string id, destination, name;
        long distance, income;
        int day;

        public string Destination { get => destination; set => destination = value; }
        public int Day { get => day; set => day = value; }

        public External(string id, string name, string destination, int day, long distance, long income) : base(id, name, distance, income)
        {
            Destination = destination;
            Day = day;
        }
        public External() : base()
        {
            destination = "";
            day = 0;

        }


        public new void input()
        {
            base.input();
            Console.Write("Nhap Ma so xe: ");
            destination = Console.ReadLine();
            Console.Write("Nhap So tuyen xe: ");
            day = Convert.ToInt32(Console.ReadLine());
        }
        public new void output()
        {
            base.output();
            Console.WriteLine("So xe: " + destination);
            Console.WriteLine("Tuyen xe: " + day);
        }
    }
}
