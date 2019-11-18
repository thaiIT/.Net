using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGUI
{
    class Animal
    {
        protected double Weight;
        protected double Height;
        protected static int Legs;

        public Animal(double w, double h, int l)
        {
            Weight = w;
            Height = h;
            Legs = l;
        }

        public void Info()
        {
            Console.WriteLine(" Weight: " + Weight + " Height: " + Height + " Legs: " + Legs);
        }
    }
}
