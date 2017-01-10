using RouteAnalysis.Worker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalysis.Worker.Analysis.Calculations
{
    public class DelayTime : ICalculation
    {
        public ICalculation NextCalculation
        {
            get; set;
        }
        public void Calculate(EventResult eventResult, Itinerary itinerary, List<Alarm> alarms)
        {
            if (true)
            {
                //Logica de tiempo de retraso
                NextCalculation.Calculate(eventResult, itinerary, alarms);
            }
            else
            {
                NextCalculation.Calculate(eventResult, itinerary, alarms);
            }
        }
    }
}
