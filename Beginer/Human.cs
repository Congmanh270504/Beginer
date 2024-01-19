using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginer
{
    internal class Human
    {
        private string name;
        private int age;
      public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
      public void Display()
        {
            Console.WriteLine("Name: " + name + " Age: " + age);
        }
    }// check banch PC

}
