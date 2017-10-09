using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HentDyreNavnPgm
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            string line;
            using (StreamReader stream = File.OpenText("X:/dyrenavne.txt"))
            {
                while (stream.Peek() != -1)
                {
                    line = stream.ReadLine();
                    Console.WriteLine(line.ToUpper());
                }
                stream.Close(); // den er godt nok lukket men den fejler ikke på det
                stream.Close();
            }


            
            Console.ReadKey();
            

            
        }
    }
}
