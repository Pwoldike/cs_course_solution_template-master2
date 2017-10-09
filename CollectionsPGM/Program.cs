using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPGM
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList lst1 =
                new System.Collections.ArrayList();

            lst1.Insert(lst1.Count, "a0"); // bedre at lave insert på lst1.count position eller?
            lst1.Add("a1");
            lst1.Add("a2");
            lst1.Insert(lst1.Count, "a5");
            lst1.RemoveAt(1);   // Her fjerner jeg på relativ position

            SortedList<string, int> lst2 = new SortedList<string, int>();

            lst2.Add("perls", 3);
            lst2.Add("dot", 1);
            lst2.Add("net", 8);

            foreach (var item in lst2)
            {
                Console.WriteLine(item);
            }

            System.Collections.Stack lst3 =
                new System.Collections.Stack();  // en stack putter altid på i toppen LIFO

            lst3.Push(1);
            lst3.Push(3);
            lst3.Push(133);
            int t = (int)lst3.Pop();

            System.Collections.Queue lst4 =
                new System.Collections.Queue(); // FILO

            lst4.Enqueue(new Hund() { Navn = "Balder" });
            lst4.Enqueue(new Hund() { Navn = "Tom" });

            Hund g = (Hund)lst4.Dequeue(); // FIFO


            System.Collections.Hashtable lst5 =
                new System.Collections.Hashtable();

            lst5.Add("a", "test");
            lst5.Add("b", "Test2");

            string r = (string)lst5["b"];

            Kennel k = new Kennel();
            k.TilføjHund(new Hund { Navn = "A" });

            System.Collections.Generic.List<Hund> lst6 = new List<Hund>();
            lst6.Add(new Hund() { Navn = "A" });
            Hund hg = lst6[0];
            

            Queue<int> lst7 = new Queue<int>();
            lst7.Enqueue(5);
            lst7.Enqueue(88);
            int ii = lst7.Dequeue();
            int co = lst7.Count;

            Dictionary<int, Hund> lst8 = new Dictionary<int, Hund>();
            lst8.Add(4, new Hund() { Navn = "A" });
            lst8.Add(23, new Hund() { Navn = "B" });

            Hund hhh = lst8[4];

            List<string> lst9 = new List<string>();
            lst9.Add("a");
            lst9.Add("B");

            foreach (var item in lst9)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }

        class Kennel
        {
            private System.Collections.ArrayList lst =
                new System.Collections.ArrayList();

            public void TilføjHund(Hund h)
            {
                lst.Add(h);
            }
        }

        class Hund
        {
            public string Navn;
        }
    }
}
