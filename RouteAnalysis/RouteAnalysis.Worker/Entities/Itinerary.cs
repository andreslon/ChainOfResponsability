using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalysis.Worker.Entities
{
    public class Itinerary
    {
        #region Columns
        public string Id { get; set; }
        public string Plaque { get; set; }
        public bool IsStarted { get; set; }
        #endregion
    }
}
