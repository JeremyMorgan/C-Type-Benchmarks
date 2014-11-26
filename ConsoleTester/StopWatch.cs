using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleTester
{
    class StopWatch
    {
        Stopwatch ourStopWatch;

        public void startStopWatch()
        {
        //Stopwatch stopwatch = new Stopwatch ();
        ourStopWatch.Start ();

        }
        
        public void stopStopWatch(){

        ourStopWatch.Stop ();
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts = ourStopWatch.Elapsed;

        // Format and display the TimeSpan value 
        string elapsedTime = String.Format ( "{0:00}: {1:00}: {2:00}} {3:00." ,
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine ( "RunTime" + elapsedTime);

        }        

      


    }
}
