using System;

namespace EgneEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h = new Hund();
            h.Navn = "Fido";
            h.SkalTisse += (s, e) =>
            {
                
                Console.WriteLine("Skal tisse");
            };
            h.SkalTisse += (s, e) =>
            {
                Console.WriteLine("Jeg skal UUUD");
            };
            h.SkalTisse2 += (s, e) =>
            {
                Hund hund = new Hund();
                Console.WriteLine(hund.Navn + "skal tisse");
            };
            h.Test();


            Console.ReadKey();

            
            
        }

        class Hund
        {
            public string Navn { get; set; }
            public event EventHandler SkalTisse;
            public event EventHandler<HundeTisEventArgs> SkalTisse2;
            public void Test()
            {
                if (SkalTisse != null)
                {
                    SkalTisse(this, new EventArgs());
                    SkalTisse2(this, new HundeTisEventArgs() { Niveau = 80 });
                }
            }


        }

        class HundeTisEventArgs : EventArgs
        {
            public int Niveau { get; set; }
        }

    }
}
