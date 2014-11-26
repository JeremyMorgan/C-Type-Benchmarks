using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ConsoleTester
{
    class Program
    {

        static void createDictionary()
        {
            Dictionary<int, string> ourdictionary = new Dictionary<int,string>();

            ourdictionary.Add(0, "1234");
            ourdictionary.Add(1, "Unit");
            ourdictionary.Add(2, "2014-11-25 21:39:07.000");
            ourdictionary.Add(3, "2014-11-25 21:39:07.000");
            ourdictionary.Add(4, "2014-11-25 21:39:07.000");
            ourdictionary.Add(5, "2014-11-25 21:39:07.000");

            Console.WriteLine(ourdictionary[0]);
            Console.WriteLine(ourdictionary[1]);
            Console.WriteLine(ourdictionary[2]);
            Console.WriteLine(ourdictionary[3]);
            Console.WriteLine(ourdictionary[4]);
            Console.WriteLine(ourdictionary[5]);

        }

        static void createObject()
        {
            UnitTime ourUnitTime = new UnitTime();

            ourUnitTime.callnum = 1234;
            ourUnitTime.unitname = "Unit";
            ourUnitTime.date1 = DateTime.Parse("2014-11-25 21:39:07.000");
            ourUnitTime.date2 = DateTime.Parse("2014-11-25 21:39:07.000");
            ourUnitTime.date3 = DateTime.Parse("2014-11-25 21:39:07.000");
            ourUnitTime.date4 = DateTime.Parse("2014-11-25 21:39:07.000");

            Console.WriteLine(ourUnitTime.callnum);
            Console.WriteLine(ourUnitTime.unitname);
            Console.WriteLine(ourUnitTime.date1);
            Console.WriteLine(ourUnitTime.date2);
            Console.WriteLine(ourUnitTime.date3);
            Console.WriteLine(ourUnitTime.date4);
        }

        static void createStruct()
        {
            UnitTimeStruct ourStruct = new UnitTimeStruct();

            ourStruct.callnum = 1234;
            ourStruct.unitname = "Unit";
            ourStruct.date1 = DateTime.Parse("2014-11-25 21:39:07.000");
            ourStruct.date2 = DateTime.Parse("2014-11-25 21:39:07.000");
            ourStruct.date3 = DateTime.Parse("2014-11-25 21:39:07.000");
            ourStruct.date4 = DateTime.Parse("2014-11-25 21:39:07.000");

            Console.WriteLine(ourStruct.callnum);
            Console.WriteLine(ourStruct.unitname);
            Console.WriteLine(ourStruct.date1);
            Console.WriteLine(ourStruct.date2);
            Console.WriteLine(ourStruct.date3);
            Console.WriteLine(ourStruct.date4);

        }
        static void Main(string[] args)
        {

            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing
            stopwatch.Start();
    
            // dictionary test
            int runs = Int32.Parse(args[1]);
            
            for (int i = 0; i < runs; i++)
            {

                switch (args[0])
                {
                    case "dictionary":
                        createDictionary();
                        break;
                    case "object":
                        createObject();
                        break;
                    case "struct":
                        createStruct();
                        break;
                }

            }

            stopwatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopwatch.Elapsed;

            // Format and display the TimeSpan value 
            //Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);

            string fileName = args[0] + "-" + args[1] + ".txt";

            using (var fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
            using (var sw = new StreamWriter(fs))
            {
                sw.WriteLine("{0}", stopwatch.Elapsed);
            }
          
        }
    }
}
