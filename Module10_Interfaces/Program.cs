namespace Module10_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

        Tandbørste t = new Tandbørste();
        t.Stop();

        IMachine[] maskiner = new IMachine[2];
        maskiner[0] = new Tandbørste();
        maskiner[1] = new Turbine();

            IDBFunktioner[] a = new IDBFunktioner[5];
            a[0] = new Tandbørste();
             
            a[1] = new Turbine();
            a[2] = new Tandbørste();
            
            a[3] = new Tandbørste();
            
            a[4] = new Turbine();

            foreach (var item in a)
            {
                item.Gem(item);
            }

        foreach (var item in maskiner)
        {
            System.Console.WriteLine(item.Fejlkode());
        }

        

            



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        public class Hund
        {

        }

        interface IDBFunktioner
        {
            void Gem();
            void Gem(IDBFunktioner item);
        }


        interface IMachine 
        {
            void Stop();
            int Fejlkode();

            int StopMaskine(int statusKode);
        }

        class Tandbørste : IMachine, IDBFunktioner
        {
            public string Navn { get; set; }
            public int Fejlkode()
            {
                return 2;
            }

            public void Gem()
            {
                Navn = "Tand";
                System.Console.WriteLine("Gemmer Tandbørste", Navn);
            }

            public void Gem(IDBFunktioner item)
            {
                Navn = "Tand";
                System.Console.WriteLine("Jeg gemmer : " + item + " " + Navn);
            }

            public void Stop()
            {
                System.Console.WriteLine("Jeg stopper Tandbørste");
            }

            public int StopMaskine(int statusKode)
            {
                return statusKode + 1;
            }
        }

        class Turbine : IMachine, IDBFunktioner
        {
            public int Fejlkode()
            {
            return 99;
            }

            public void Gem()
            {
                System.Console.WriteLine("Gemmer Turbine");
            }

            public void Gem(IDBFunktioner item)
            {
                System.Console.WriteLine("Jeg gemmer : " + item);
            }

            public void Stop()
            {
                System.Console.WriteLine("Jeg stopper Turbine");
            }

            public int StopMaskine(int statusKode)
            {
                return statusKode + 100;
            }
        }
    }
}
