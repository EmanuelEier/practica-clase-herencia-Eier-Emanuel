using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Camioneta : Vehiculo
    {
        public int cantPuertas { get; set; }

        public string cuatroPorCuatro { get; set; }

        string resultado;
        public override string MostrarInformacion()
        {
            if (cuatroPorCuatro == "S")
            {
                resultado = "La camioneta es 4x4";
            } else
            {
                resultado = "La camioneta no es 4x4";
            }

            return base.MostrarInformacion() + ". " +
                $"- Cantidad de puertas: {cantPuertas} + " +
                $"{resultado}";

        }
    }
}