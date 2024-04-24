using biblioteca;

List<Vehiculo> Listavehiculos = new List<Vehiculo>();


for (int i = 0; i < 3; i++)
{
    {
        Console.WriteLine("Ingrese si es un auto o una camioneta. A = Auto / C = Camioneta");
        string tipovehiculo = Console.ReadLine().ToUpper();

        Console.WriteLine("Ingrese su marca:");
        string marca = Console.ReadLine();

        Console.WriteLine("Ingrese su modelo:");
        string modelo = Console.ReadLine();

        Console.WriteLine("Ingrese su año:");
        int año = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad de puertas:");
        int cantpuertas = int.Parse(Console.ReadLine());

        if (tipovehiculo == "C")
        {
            Console.WriteLine("¿La camioneta es 4x4? S = SI / N = NO");
            string cuatroxcuatro = Console.ReadLine();

            Camioneta camionetas = new Camioneta();
            camionetas.Marca = marca;
            camionetas.Modelo = modelo;
            camionetas.Año = año;
            camionetas.cantPuertas = cantpuertas;
            camionetas.cuatroPorCuatro = cuatroxcuatro;

            Listavehiculos.Add(camionetas);
        }
        else
        {
            Auto autos = new Auto();

            autos.Marca = marca;
            autos.Modelo = modelo;
            autos.Año = año;
            autos.cantPuertas = cantpuertas;

            Listavehiculos.Add(autos);
        }

    }
}

int g = 0;
foreach (Vehiculo item in Listavehiculos)
{
    Console.WriteLine("");
    Console.WriteLine(Listavehiculos[g].MostrarInformacion());
    g++;
}