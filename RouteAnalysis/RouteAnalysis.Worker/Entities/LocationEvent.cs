using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalysis.Worker.Entities
{
    public class LocationEvent
    {
        public string id { get; set; }
        public string Placa { get; set; }
        public string FechaGeneracion { get; set; }
        public string FechaHoraRegistro { get; set; }
        public int Velocidad { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Direccion { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Comuna { get; set; }
        public string Barrio { get; set; }
        public object PuntoCliente_String { get; set; }
        public int FechaGeneracionEpoch { get; set; }
        public int FechaHoraRegistroEpoch { get; set; }
        public string TipoUnidad { get; set; }
    }
}
