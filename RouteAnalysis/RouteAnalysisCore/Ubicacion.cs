using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalysisCore
{
    public class Ubicacion
    {
        private double latitud;
        private double longitud; 

        public Ubicacion(double v1, double v2)
        {
            this.latitud = v1;
            this.longitud = v2;
        }
    }
}
