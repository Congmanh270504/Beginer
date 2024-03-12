using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Beginer.Student
{
    public class Student
    {
        string id, name;
        double point;
        public Student(string _id, string _name, double _point)
        {
            id = _id;
            name = _name;
            point = _point;
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
