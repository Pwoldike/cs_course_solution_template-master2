using System.IO.Compression;
using System;
using System.IO;



namespace Zipper
{
    class Program
    {
        static void Main(string[] args)
        {
            string startPathArgs = null;
            string zipPathArgs = null;
            string extractPathArgs = null;

            if (args.Length == 1)
            {
                startPathArgs = args[0];
            }
            if (args.Length == 2)
            {
                startPathArgs = args[0];
                zipPathArgs = args[1];
            }
            if (args.Length == 3)
            {
                startPathArgs = args[0];
                zipPathArgs = args[1];
                extractPathArgs = args[2];
            }

            string startPath;


            if (startPathArgs == null)
            {
                startPath = @"E:\example\start";
            }
            else
            {
                startPath = startPathArgs;
            }

            string zipPath;

            if (zipPathArgs == null)
            {
                zipPath = @"E:\example\resultat.zip";
            }
            else
            {
                zipPath = zipPathArgs;
            }

            string extractPath;

            if (extractPathArgs == null)
            {
                extractPath = @"E:\example\extract";
            }
            else
            {
                extractPath = extractPathArgs;
            }

            
            if (File.Exists(zipPath))
            {
                File.Delete(zipPath);
            }

            

            NewMethod(startPath, zipPath);
            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }

        private static void NewMethod(string startPath, string zipPath)
        {
            System.IO.Compression.ZipFile.CreateFromDirectory(startPath, zipPath);
        }

        
    }
}