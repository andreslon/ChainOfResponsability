using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalysis.Worker.Analysis
{
    public class EventResult
    {
        public EventResult()
        {
        } 
        public bool IsStarted { get; set; }
        public bool IsFinished { get; set; }
        public int DelayTime { get; set; }  
    }
}
