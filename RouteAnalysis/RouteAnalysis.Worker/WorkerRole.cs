using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;
using Microsoft.WindowsAzure.Storage;
using RouteAnalysis.Worker.Analysis;

namespace RouteAnalysis.Worker
{
    public class WorkerRole : RoleEntryPoint
    {
        private const int DEFAULT_SLEEP_TIME = 5000;
        private readonly CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        private readonly ManualResetEvent runCompleteEvent = new ManualResetEvent(false);

        public override void Run()
        {
            Trace.TraceInformation("RouteAnalysis.Worker is running");

            try
            {
                this.RunAsync(this.cancellationTokenSource.Token).Wait();
            }
            finally
            {
                this.runCompleteEvent.Set();
            }
        }

        public override bool OnStart()
        {
            // Set the maximum number of concurrent connections
            ServicePointManager.DefaultConnectionLimit = 12;

            // For information on handling configuration changes
            // see the MSDN topic at https://go.microsoft.com/fwlink/?LinkId=166357.

            bool result = base.OnStart();

            Trace.TraceInformation("RouteAnalysis.Worker has been started");

            return result;
        }

        public override void OnStop()
        {
            Trace.TraceInformation("RouteAnalysis.Worker is stopping");

            this.cancellationTokenSource.Cancel();
            this.runCompleteEvent.WaitOne();

            base.OnStop();

            Trace.TraceInformation("RouteAnalysis.Worker has stopped");
        }

        private async Task RunAsync(CancellationToken cancellationToken)
        {
            QueueProcessor qp = null;
            // TODO: Replace the following with your own logic.
            while (!cancellationToken.IsCancellationRequested)
            {
                Trace.TraceInformation("Working");
                try
                {
                    qp = new QueueProcessor();
                    qp.Process();
                    //Thread.Sleep(DEFAULT_SLEEP_TIME);
                }
                catch (Exception ex)
                { 
                    Trace.TraceError("Error", String.Format("Error occured, trying again - {0}",
                        ex.ToString()));
                }
            }
        }
    }
}
