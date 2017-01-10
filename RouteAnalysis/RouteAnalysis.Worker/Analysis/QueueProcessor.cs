using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using RouteAnalysis.Worker.Entities;
using Newtonsoft.Json;
using RouteAnalysis.Worker.Utilities;
using System.Data;
using System.Data.Common;
using RouteAnalysis.Worker.Repositories.Interfaces;
using RouteAnalysis.Worker.Repositories;
using RouteAnalysis.Worker.Analysis.Calculations;

namespace RouteAnalysis.Worker.Analysis
{
    class QueueProcessor
    {
        internal void Process()
        {
            //Read event from Queue 
            LocationEvent eventInput = ReadQueue();
            if (eventInput != null)
            {
                try
                {
                    IRepository<Itinerary> repository = new ItineraryRepository();
                    var itineraries = repository.List;
                    foreach (var itinerary in itineraries)
                    {

                        ICalculation startRoute = new StartRoute() { };
                        ICalculation delayTime = new DelayTime() { };
                        ICalculation finishRoute = new FinishRoute() { };

                        delayTime.NextCalculation = finishRoute;
                        startRoute.NextCalculation = delayTime;

                        //Lista de alarmas
                        var alarms = new List<Alarm>();
                        startRoute.Calculate(new EventResult(), itinerary, alarms);

                    }
                }
                catch (Exception ex)
                {
                    //Save event in queue again
                }
            }
        }

        private LocationEvent ReadQueue()
        {
            //Get Event
            LocationEvent eventInput = null;
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=andreslonstorage;AccountKey=PG4jkvaU2ffrllNwcgFCR624C8uHRW05Vm2bZ3Xhpk2k8ogrgVTi2/stYl+VkvMvA7TsG8BLNicelYfu10FvDQ==");
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();
            CloudQueue queue = queueClient.GetQueueReference("routequeuetest");
            if (queue.Exists())
            {
                CloudQueueMessage message = queue.GetMessage();
                if (message != null)
                {
                    string data = message.AsString;
                    eventInput = JsonConvert.DeserializeObject<LocationEvent>(data);
                }
            }
            return eventInput;
        }
    }
}
