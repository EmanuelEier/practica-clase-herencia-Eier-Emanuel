using biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Auto : Vehiculo
    {
        public int cantPuertas { get; set; }

        public override string MostrarInformacion()
        {
            
            return base.MostrarInformacion() + ". " +
                $"- Cantidad de puertas: {cantPuertas}" +
                " -No es 4x4";
        }

    }
}