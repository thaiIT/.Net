using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGUI
{
    class ManhDat
    {
        protected double chieu_dai;
        protected double chieu_rong;
        // constructor
        public ManhDat(double l, double w)
        {
            chieu_dai = l;
            chieu_rong = w;
        }
        public double tinhDienTich()
        {
            return chieu_dai * chieu_rong;
        }
        public void display()
        {
            Console.WriteLine("Chieu dai: {0}", chieu_dai);
            Console.WriteLine("Chieu rong: {0}", chieu_rong);
            Console.WriteLine("Dien tich: {0}", tinhDienTich());
        }
    }
}
