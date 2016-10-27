using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;

namespace ProductsApp.Templates
{
    public class Threading
    {
        private static readonly object lockObj = new object();
        public void DoSomething()
        {
            var myThread = new Thread(() => 
            {
                Monitor.Enter(lockObj);
                //DoSomething on separate thread

                Monitor.Exit(lockObj);
                Monitor.Pulse(lockObj);

            });

            // kick off thread
            myThread.Start();

            // wait for completion
            myThread.Join();

            
        }
    }
}