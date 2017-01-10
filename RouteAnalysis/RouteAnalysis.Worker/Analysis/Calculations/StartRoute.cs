using RouteAnalysis.Worker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalysis.Worker.Analysis.Calculations
{
    public class StartRoute : ICalculation
    {
        public ICalculation NextCalculation
        {
            get; set;
        }
        public void Calculate(EventResult eventResult, Itinerary itinerary, List<Alarm> alarms)
        {
            if (true)
            {

                if (itinerary.IsStarted)
                {
                    //Logica para realizar los calculos cuando la ruta ya esta iniciada
                    NextCalculation.Calculate(eventResult, itinerary, alarms);
                }
                else
                {
                    eventResult.IsStarted = true;
                    NextCalculation.Calculate(eventResult, itinerary, alarms);
                }
            }
            else
            {
                NextCalculation.Calculate(eventResult, itinerary, alarms);
            }
        }
    }
}
