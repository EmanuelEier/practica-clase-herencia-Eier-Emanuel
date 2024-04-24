namespace biblioteca
{
    public class Vehiculo
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Año { get; set; }

        public Vehiculo() { }

        public virtual string MostrarInformacion()
        {
            return "=== Las caracteristicas del vehículo ingresado son ===" +

                    $"- Marca: {Marca}" +
                    $"- Modelo: {Modelo}" +
                    $"- Año: {Año}";
        }
    }
}