﻿using System;
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

    class Cat : Animal
    {
        public Cat(double w, double h, int l) : base(w, h, l)
        {
            //Weight = 600;
            //Height = 20;
            //Legs = 2;
        }

        //public Cat()
        //{
        //    /*
        //    Lớp Cat kế thừa lớp Animal
        //    mà các thuộc tính Weight, Height, Legs có phạm vi là protected nên được phép kế thừa
        //    Từ đó lớp Cat có thể sử dụng mà không cần phải khai báo
        //     */
        //    Weight = 500;
        //    Height = 20;
        //    Legs = 2;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat BlackCat = new Cat(1,1,1);
            BlackCat.Info();
            Console.ReadKey();
        }
    }
}
