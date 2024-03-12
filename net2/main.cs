namespace net2
{
    internal class main
    {
        static void Main(string[] args)
        {
            EmployeeList employeesList = new EmployeeList();
            employeesList.Add();
            //employeesList.Add(new Employee("4312a", "Manh", 1.0, 2013));
            Console.WriteLine(employeesList[0]);

            Console.ReadKey();
        }
    }
    public class Employee
    {
        private
        static long MLTT = 1500000;
        string id;
        string name;
        double salaryPoint;

        int timeWork;
        long salary;

        public Employee(string id, string name, double salaryPoint, int timework)
        {
            this.id = id;
            this.name = name;
            this.salaryPoint = salaryPoint;
            this.timeWork = timework;
        }
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public int TimeWork { get => timeWork; set => timeWork = value; }
        public double SalaryPoint { get => salaryPoint; set => salaryPoint = value; }
        public static double allowancePoint(int timeWork)
        {
            return (double)(DateTime.Now.Year - timeWork) / 100;
        }
        public double basicSalary()
        {
            return (double)SalaryPoint * MLTT;
        }
        public double getSalary()
        {
            return allowancePoint(timeWork) * basicSalary();
        }
        public void getInfor()
        {
            Console.WriteLine("Ma nhan vien: " + id);
            Console.WriteLine("Ten nhan vien: " + name);
            Console.WriteLine("He so luong: " + salaryPoint);
            Console.WriteLine("Thoi gian vao lam: " + timeWork + "\n");
        }
       
    }

    public class EmployeeList
    {
        List<Employee> employees = new List<Employee>();

        public List<Employee> Employees { get => employees; set => employees = value; }
        public void Add()
        {
            employees.Add(new Employee("4312a", "Manh", 1.0, 2013));
            employees.Add(new Employee("765B", "Son", 2.0, 2008));
            employees.Add(new Employee("078C", "Quy", 3.5, 2015));
            employees.Add(new Employee("1234D", "Tan", 4.0, 2018));
        }
        public void swap<T>(List<T> list, ref int a, ref int b)
        {
            T temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
        public void interchangeTimeWork(List<Employee> employees)
        {
            for (int i = 0; i < employees.LongCount() - 1; i++)
            {
                for (int j = i + 1; j < employees.LongCount(); j++)
                {
                    if (employees.ElementAt(i).TimeWork > employees.ElementAt(j).TimeWork)
                    {
                        swap(employees, ref i, ref j);
                    }
                }
            }
        }
    }
}
