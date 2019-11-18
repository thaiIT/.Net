using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGUI
{
    class ChiPhiXayDung : ManhDat
    {
        private double chi_phi;
        public ChiPhiXayDung(double l, double w) : base(l, w) 
        {
        
        }
        public double tinhChiPhi()
        {
            chi_phi = tinhDienTich() * 70;
            return chi_phi;
        }
        public void hienThiThongTin()
        {
            base.display();
            Console.WriteLine("Chi phi : {0}", tinhChiPhi());
        }

    }
}
