using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Threading.Tasks;

namespace ProductsApp.Templates
{
    public class TaskParallel
    {
        public void DoSomethingWithTasks()
        {
            var tokenSrc = new CancellationTokenSource();
            var token = tokenSrc.Token;


            var result = Task.Factory.StartNew(
                () =>
                {
                        // Call some service async

                });


            result.ContinueWith((output) => 
            {

                var error = output.Exception.Flatten();

            }, TaskContinuationOptions.OnlyOnFaulted);


            result.ContinueWith((output) =>
            {

                // run on ui thread


            }, token, TaskContinuationOptions.OnlyOnRanToCompletion, TaskScheduler.FromCurrentSynchronizationContext());


            try
            {
                result.Wait();
            }
            catch (AggregateException e)
            {
                var error = e.Flatten();

                string.Format("An error occured: {0}", error.InnerException);
            }

        }


        private void DoSomeParrallel()
        {

            var source = Enumerable.Range(100, 2000);

            Parallel.Invoke(() =>
           { 
               //DoSomething 
           } );


           var list = new List<object>();
            Parallel.ForEach(list, item =>
            {
                // do something with item
            });

            var parResult = (from num in source.AsParallel()
                             where num % 10 == 0
                             select num).ToArray();

            var parResult2 = source.AsParallel().Where(n => n % 10 == 0).Select(n => n);

        }

    }
}