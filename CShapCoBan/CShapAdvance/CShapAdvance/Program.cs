using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CShapAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  ArrayList
             */
            ArrayList arrPersons = new ArrayList();
            arrPersons.Add(new Person("Nguyen Van A", 18));
            arrPersons.Add(new Person("Nguyen Van B", 25));
            arrPersons.Add(new Person("Nguyen Van C", 20));

            //Console.WriteLine("Danh sach Person ban dau: ");
            foreach (Person item in arrPersons)
            {
                //Console.WriteLine(item.ToString());
            }

            arrPersons.Sort(new SortPersons());
            //Console.WriteLine("Danh sach Person da duoc sap xep theo tuoi tang dan: ");
            foreach (Person item in arrPersons)
            {
                //Console.WriteLine(item.ToString());
            }

            /*
             * Hashtable
             */
            Hashtable MyHash = new Hashtable();
            MyHash.Add("T", "Thai Hoang");
            MyHash.Add("B", "Binh");
            MyHash.Add("D", "Duc");

            Hashtable newHash = new Hashtable(MyHash);
            //Console.WriteLine(newHash.ContainsKey("G"));
            newHash["G"] = "Giang";
            //Console.WriteLine("MyHash : \n");
            //Console.WriteLine("So phan tu MyHash " + MyHash.Count + "\n");

            foreach (DictionaryEntry item in MyHash)
            {
                //Console.WriteLine(item.Key + "\t" + item.Value);
            }

            //Console.WriteLine("\nnewHash : \n");
            //Console.WriteLine("So phan tu newHash " + newHash.Count + "\n");
            foreach (DictionaryEntry item in newHash)
            {
                //Console.WriteLine(item.Key + "\t" + item.Value);
            }

            /*
             * SortedList
             * (ArrayList X Hashtable)
             */
            SortedList MySL = new SortedList();

            /*
             * Stack
             */
            ArrayList MyArray = new ArrayList();
            MyArray.Add(5);
            MyArray.Add(7);
            MyArray.Add(9);
            Stack MyStack = new Stack(MyArray);
            MyStack.Push("Education");
            MyStack.Push("Free");
            MyStack.Push("HowKteam");
            Console.WriteLine(" So phan tu hien tai cua Stack la: {0}", MyStack.Count);
            Console.ReadKey();


        }
    }
}
