using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DataStructures
{
    class Program
    {
        private static int SIZE_LOG_LINES = 100000;
        private static int SIZE_UNIQUE_IPS = 90001;
        private static logReader logReader = new logReader(SIZE_LOG_LINES, SIZE_UNIQUE_IPS);

        static void Main(string[] args)
        {
            Console.WriteLine("Reading all log entries...");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int sizeLogLines = logReader.readAllLogs();
            Console.WriteLine("Number of lines:" +sizeLogLines);
            Console.WriteLine("Time elapsed: " + stopwatch.Elapsed + " milliseconds");

            Console.WriteLine("Processing unique IPs...");
            stopwatch.Reset();
            stopwatch.Start();
            int sizeUniqueIps = logReader.getSizeUniqueIps();
            Console.WriteLine( "Number of unique IPs: " + sizeUniqueIps);
            Console.WriteLine("Time elapsed: " + stopwatch.Elapsed.TotalSeconds+ " seconds");
            Console.Read();
        }
    }
}
