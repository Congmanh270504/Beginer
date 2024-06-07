using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    abstract class T
    {
        string id, name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public T()
        {
            id = "00";
            name = "cc";
        }
        public T(string id ,string name)
        {
            this.id = id;
            this.name = name;
        }
        public abstract double Salary();
        public abstract string Title();
    }
}
