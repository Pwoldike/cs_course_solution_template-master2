using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12Pgm
{
    class Program
    {
        public delegate void MinFunktion();
        public delegate bool MinFunktion2(int a);
        public delegate double MinFunktion3(double d1, double d2);
        public delegate void MinFunktion4(string t);
        public delegate int BeregnDelegate(int a, int b);

        

        static void Main(string[] args)
        {
            int res = Beregner(1, 1, Plus);
            Console.WriteLine(res);
            res = Beregner(200, 300, Gange);
            Console.WriteLine(res);
            res = Beregner(200, 50, Divider);
            Console.WriteLine(res);
            res = Beregner(1, 2, Increment);
            Console.WriteLine(res);
            res = Beregner(1, 2, Increment);
            Console.WriteLine(res);

            MinFunktion m1 = new MinFunktion(Test1);   // ikke kald til funktion
            Test1();
            m1.Invoke();

            Action p1 = Test1;
            Action < string > p2 = Console.WriteLine;
            Action < string, object> p3 = Console.WriteLine;


            Func<int, int, int> p4 = Plus;

            Func<double, double, double> p5 = Math.Atan2;


            Action<string> p6 = Test4;
            p6 += Console.WriteLine;

            p6 += delegate (string txt)
            { Console.WriteLine("****" + txt); };

            p6 += t =>      // Eksempel på lampda parser tekst til fil - hvilken tekst (se p6("******");) 
            {
                System.IO.File.WriteAllText(@"c:\templog1.txt", t);
            };

            p6("******");

            int[] a = { 5, 8, 76, 7, 7, 77 };           // Eksempel på lampda
            var b = Array.FindAll(a, type => type < 10);  // lav nyt array med værdier under 10


            MinFunktion2 m2 = new MinFunktion2(Test2);
            bool r1 = Test2(5);
            r1 = m2.Invoke(89);





            Console.ReadKey();
        }

        public static int Beregner(int a, int b, BeregnDelegate funktion)
        {
            return funktion(a, b);
        }

        static void Test1()
        {
            Console.WriteLine("Test1");
        }

        static bool Test2(int t)
        {
            Console.WriteLine("Test2");
            return true;
        }

        static void Test4(string ty)
        {
            Console.WriteLine("I min egen void :" + ty);
        }
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Gange(int a, int b)
        {
            return a * b;
        }
        public static int Divider(int a, int b)
        {
            int c = Increment(a, b);
            return c / b;
        }
        public static int Increment(int a, int b)
        {
            
            return a + a + b + b; 
        }
    }
}
