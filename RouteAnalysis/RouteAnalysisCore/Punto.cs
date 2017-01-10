using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalysisCore
{
    public class Punto
    {
        private double latitud;
        private double longitud; 
        private int radio;

        public Punto(double v1, double v2)
        {
            this.latitud = v1;
            this.longitud = v2; 
        }

        public Punto(double v1, double v2, int v3)
        {
            this.latitud = v1;
            this.longitud = v2;
            this.radio = v3;
        }
    }
}
