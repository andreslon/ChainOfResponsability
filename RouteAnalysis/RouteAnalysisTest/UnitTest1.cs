using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RouteAnalysisCore;

namespace RouteAnalysisTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VehiculoPasoPorPuestoControl()
        {
            Ruta ruta = new Ruta();
            ruta.PuntoInicial = new Punto(6.216118, -75.5840);
            ruta.PuntoIntermedio = new Punto(6.215797, -75.583464, 150);
            ruta.PuntoFinal = new Punto(6.215563, -75.583081);

            PasoPorPuestoDeControl pasoPorPuestoDeControl = new PasoPorPuestoDeControl(new Ubicacion(6.215933, -75.583782), new Itinerario(ruta));
            var result = pasoPorPuestoDeControl.Procesar();

            Assert.IsNotNull(result);
            Assert.Equals(result.Mensaje, "Paso por puesto de control");
        }
    }
}
