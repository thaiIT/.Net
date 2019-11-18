using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGUI
{

    class Program
    {
        static void Main(string[] args)
        {

            //Cat BlackCat = new Cat(1,1,1);
            //BlackCat.Info();

            Console.WriteLine("Tinh ke thua trong C#: ");
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.setChieuRong(5);
            hcn.setChieuCao(7);
            Console.WriteLine("Dien tich hinh chu nhat: {0}", hcn.tinhDienTich());
            Console.WriteLine("*************************");
            Console.WriteLine("Khoi tao lop co so: ");
            ChiPhiXayDung t = new ChiPhiXayDung(4.5, 7.5);
            t.hienThiThongTin();
            Console.WriteLine("*************************");
            Console.WriteLine("Vi du minh hoa Da ke thua: ");
            CanNha cn = new CanNha();
            cn.setChieuRong(5);
            cn.setChieuCao(7);
            int dien_tich = cn.tinhDienTich();
            Console.WriteLine("Tong dien tich: {0}", cn.tinhDienTich());
            Console.WriteLine("Tong chi phi son: ${0}", cn.tinhChiPhi(dien_tich));

            Console.ReadKey();
        }
    }
}
