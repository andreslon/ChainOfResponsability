using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalysisCore
{
    public class Itinerario
    {
        private Ruta ruta;

        public Itinerario(Ruta ruta)
        {
            this.ruta = ruta;
        }

        public Vehiculo Vehiculo { get; set; }

        internal Punto ObtenerSiguientePuestoDeControl(Punto ultimoPunto)
        {
            //retorna el siguiente al ultimoPunto
            return ruta.PuntoIntermedio;
        }
    }
}
