using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Beginer
{
    public class Student
    {
        string id, name;
        double point;
        public Student(string id, string name, double point)
        {
            this.id = id;
            this.name = name;
            this.point = point;
        }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Point { get => point; set => point = value; }
        public void getInfor()
        {
            Console.WriteLine("ID: " + Id + "\tName: " + Name + "\tDiem: " + Point);
        }


    }
}
