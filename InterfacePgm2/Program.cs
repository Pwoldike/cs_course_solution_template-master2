using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePgm2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[5];
            hunde[0] = new Hund { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund { Alder = 4, Navn = "Bull" };
            hunde[2] = new Hund { Alder = 1, Navn = "Køter" };
            hunde[3] = new Hund { Alder = 4, Navn = "Tyr" };
            hunde[4] = new Hund { Alder = 3, Navn = "Nan" };

            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }
            Console.ReadKey();
        }
    }

    class Hund : IComparable
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {
            Hund h = obj as Hund;
            if (h.Alder > this.Alder)
            
                return -1;
            
            if (h.Alder < this.Alder)
            
                return 1;

            return 0;
            
        }
    }
}
