using RouteAnalysis.Worker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalysis.Worker.Analysis.Calculations
{
   public class FinishRoute : ICalculation
    {
        public ICalculation NextCalculation
        {
            get; set;
        }
        public void Calculate(EventResult eventResult, Itinerary itinerary, List<Alarm> alarms)
        {
            if (true)
            {
                //Logica para finalizar una ruta
              
                ResultProcessor.Process(eventResult, alarms);
            }
            else
            {
                
            }
        }
    }
}
