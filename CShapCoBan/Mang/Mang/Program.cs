using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Cu Phap
            <Kieu du lieu>[] <ten mang>;
            <Kieu du lieu>[] <ten mang> = new <kieu du lieu>[] {<gia tri 1>, ..., <gia tri n>};
            */
            //String[] Kteam = new string[3];
            //int[] intArray = { 3, 9, 10 };
            //string[] Array = new string[3];
            //string[] Kteam2 = new string[] { "HowKteam", "Free Education" };
            //Console.WriteLine(Kteam2[1]);
            //Console.ReadKey();
            /*
             * Mang mot chieu
            int Year;
            string[] Can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
            string[] Chi = { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Meo","Thin", "Ty", "Ngo", "Mui" };
            Console.WriteLine("Moi ban nhap mot nam bat ky: ");
            Year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nam {0} co nam am lich la: {1} {2}", Year, Can[Year % 10], Chi[Year % 12]);
            //Console.ReadLine();
            Console.ReadKey();
            */
            /*
             * Mang 2 chieu
             * Cu phap: <kieu du lieu> [,] <ten mang>;
            */
            Console.Write("Moi ban nhap so dong cua mang: ");
            int Rows = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap so cot cua mang: ");
            int Columns = int.Parse(Console.ReadLine());
            int[,] IntArray = new int[Rows, Columns];
            for(int i = 0; i < IntArray.GetLength(0); i++)
            {
                for (int j = 0; j < IntArray.GetLength(1); j++)
                {
                    Console.Write(" Moi ban nhap phan tu IntArray[{0}, {1}] = ", i, j);
                    IntArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int Sum = 0;
            Console.WriteLine("\n Mang ban vua nhap la: ");
            for(int i = 0; i < IntArray.GetLength(0); i++)
            {
                for(int j = 0; j < IntArray.GetLength(1); j++)
                {
                    Console.Write(IntArray[i, j] + " " );
                    Sum = Sum + IntArray[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine(" Tong cac gia tri trong mang: " + Sum);
            Console.ReadKey();
        }
    }
}
