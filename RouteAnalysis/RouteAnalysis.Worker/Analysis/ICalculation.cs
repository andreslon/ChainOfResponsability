
using RouteAnalysis.Worker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalysis.Worker.Analysis
{
    public interface ICalculation
    {
        ICalculation NextCalculation { get; set; }

        void Calculate(EventResult EventResult, Itinerary itinerary, List<Alarm> alarms);
    }
}
