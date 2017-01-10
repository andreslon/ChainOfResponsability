using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalysisCore
{
    public class PasoPorPuestoDeControl
    {
        private Itinerario itinerario;
        private Ubicacion ubicacion;
        private Punto UltimoPunto { get; set; }

        public PasoPorPuestoDeControl(Ubicacion ubicacion, Itinerario itinerario)
        {
            this.ubicacion = ubicacion;
            this.itinerario = itinerario;
        }

        public Evento Procesar()
        {
            Evento result = null;
            var puestoDeControl = itinerario.ObtenerSiguientePuestoDeControl(UltimoPunto);
            var response = DeterminarUbicacionEnRadioDePuestoDeControl(puestoDeControl, ubicacion);
            if (response)
            {
                result = new Evento();
                //Envia a la cola el evento
                result.Mensaje = "Paso por puesto de control";
            }
            return result;
        }

        private bool DeterminarUbicacionEnRadioDePuestoDeControl(Punto puestoDeControl, Ubicacion ubicacion)
        {
            //Logica para calculo que determine si la ubicacion se encuentra dentro del radio del puesto de control



            return true;
        }
    }
}
