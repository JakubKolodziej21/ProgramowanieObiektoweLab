using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_zadanie
{
    class Meat : Product

    {

        double weight;

        public double Weight { get { return weight; } }
        public Meat(string name, double weight):base(name)
        {
            this.weight = weight;
        }
        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + this.name + " (" + this.weight + " kg)");
        }
    }
}
