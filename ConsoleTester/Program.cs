using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using HtmlAgilityPack;
using System.Diagnostics;

namespace ConsoleTester
{
    class Program
    {

        int callnum;
        string unitname;
        DateTime date1;
        DateTime date2;
        DateTime date3;
        DateTime date4;


        static void createDictionary()
        {
            Dictionary<int, string> ourdictionary = new Dictionary<int,string>();

            ourdictionary.Add(0, "1234");
            ourdictionary.Add(1, "Unit");
            ourdictionary.Add(2, "2014-11-25 21:39:07.000");
            ourdictionary.Add(3, "2014-11-25 21:39:07.000");
            ourdictionary.Add(4, "2014-11-25 21:39:07.000");
            ourdictionary.Add(5, "2014-11-25 21:39:07.000");

            // convert stuff

            Int32.Parse(ourdictionary[0]);
            DateTime.Parse(ourdictionary[2]);
            DateTime.Parse(ourdictionary[2]);
            DateTime.Parse(ourdictionary[2]);
            DateTime.Parse(ourdictionary[2]);
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

        }
        static void Main(string[] args)
        {

            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing
            stopwatch.Start();
    
            // dictionary test
            int runs = 1000000;

            for (int i = 0; i < runs; i++)
            {
                //createDictionary();
                //createObject();
                createStruct();

            }

            stopwatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopwatch.Elapsed;

            // Format and display the TimeSpan value 
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
          
                Console.ReadLine();

        }
    }
}
