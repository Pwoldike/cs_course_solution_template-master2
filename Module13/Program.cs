using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13
{
    class Program
    {
        static void Main(string[] args)
        {
            // lav et event når der er gået 1000 ms
            System.Timers.Timer t = new System.Timers.Timer();
            t.Enabled = true;
            t.Interval = 1000;
            t.Elapsed += (ss, eee) =>
                {

                    Console.WriteLine("Tick", eee);
                };

            Console.ReadKey();
            //return;


            // Lav et event når der sker en ændring på mappen


            //System.IO.FileSystemWatcher fw = new System.IO.FileSystemWatcher(@"C:\temp");   // alt blive overvåget
            System.IO.FileSystemWatcher fw = new System.IO.FileSystemWatcher(@"C:\temp", "*.txt");   // kun *.txt bliver overvåget
            fw.EnableRaisingEvents = true;

            fw.Created += Fw_Created; // Her sker det via en static void Fw_created

            fw.Deleted += delegate (object s, System.IO.FileSystemEventArgs e)  // Her sker det via en delegate
            {
                Console.WriteLine("Fil slettet : ", e.FullPath);
            };
            fw.Changed += (s, e) =>     // Her sker det via en lampda
            {
                Console.WriteLine("Fil rettet : ", e.FullPath);
            };

            


            do
            {

            } while (true);
            

        }

        private static void Fw_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Fil oprettet :" + e.FullPath);
        }
    }
}
