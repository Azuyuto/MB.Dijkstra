using MB.Dijkstra.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MB.Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileEntries = System.IO.Directory.GetFiles("../../Data/");
            foreach(var fileName in fileEntries)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(String.Format("Found file: {0}, starting dijkstra algorithm.", fileName));
                Console.ForegroundColor = ConsoleColor.Blue;
                DijkstraService.FindShortestPathByFile(fileName);
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Press any key to exit :)");
            Console.ReadKey();
        }
    }
}
