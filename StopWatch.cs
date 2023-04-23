using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;


namespace Time
{
    internal class StopWatch
    {
        public DateTime startTime;       
        public DateTime endTime;
        public void SelectionSortTimer()
        {
            startTime = DateTime.Now;
        }
        public DateTime StartTime()
        {
            return startTime;
        }
        public DateTime EndTime() 
        {           
             return endTime; 
        }
        public void Start()
        {
            startTime = DateTime.Now;
            string Start = startTime.ToString("dd-MM-yyyy HH:mm:ss.fff");
            Console.WriteLine("Thời gian Start: " + Start);
        }
        public void Stop()
        {
            endTime = DateTime.Now;
            string End = endTime.ToString("dd-mm-yyyy hh:mm:ss.fff");
            Console.WriteLine("thời gian stop: " + End);
        }
        public double GetElapsedTime()
        {
            TimeSpan elapsed = endTime-startTime;            
            return elapsed.TotalMilliseconds;
        }
    }
    
}
 