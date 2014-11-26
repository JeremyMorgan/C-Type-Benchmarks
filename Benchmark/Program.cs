using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new stopwatch
            var stopwatch = new Stopwatch();

            // Begin timing
            stopwatch.Start();
    
            // dictionary test
            var runs = Int32.Parse(args[1]);

            var ourTester = new Tester();

            for (int i = 0; i < runs; i++)
            {

                switch (args[0])
                {
                    case "dictionary":
                        ourTester.CreateDictionary();                                           
                        break;
                    case "object":
                        ourTester.CreateObject();
                        break;
                    case "struct":
                        ourTester.CreateStruct();
                        break;
                }

            }

            stopwatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            var ts = stopwatch.Elapsed;
            
            // create a filename based on the test
            string fileName = args[0] + "-" + args[1] + ".txt";

            using (var fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
            using (var sw = new StreamWriter(fs))
            {
                sw.WriteLine("{0}", stopwatch.Elapsed);
            }
        }
    }
}
