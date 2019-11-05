using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumGUI
{
    class Program
    {
        enum Color
        {
            RED,
            BLUE,
            YELLOW
        }
        static void Main(string[] args)
        {
            int Choose = int.Parse(Console.ReadLine());
            if (Choose == (int)Color.RED) ; // lỗi vì không thể so sánh trực tiếp 1 enum với 1 số nguyên
            {

                Console.WriteLine("Ban vua chon mau do");
                Console.ReadKey();

            }
        }
    }
}
