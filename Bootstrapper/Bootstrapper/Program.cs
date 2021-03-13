using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace Bootstrapper
{
    class Program
    {
        static string[] files = new string[] {
            "https://example.com/example.zip" //Direct Raw ZIP Download Link
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Version: ");
            if (!Directory.Exists(Environment.CurrentDirectory + "/Updated"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "/Updated");
            }
            Console.Title = "Bootstrapper";

            Console.WriteLine("Downloading.");
            Console.WriteLine("Downloading..");
            Console.WriteLine("Downloading...");

            foreach (string file in files)
            {
                string name = file.Substring(file.LastIndexOf("/") + 1);
                try
                {
                    Console.WriteLine("Creating Files...");
                    new WebClient().DownloadFile(new Uri(file), Environment.CurrentDirectory + "/Updated/" + name);
                }
                catch (IOException ex)
                {

                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Finished Downloading!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
            Environment.Exit(0);
            Console.Read();
        }
    }
}

