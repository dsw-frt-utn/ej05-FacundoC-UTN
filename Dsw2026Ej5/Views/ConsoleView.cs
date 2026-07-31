namespace Dsw2026Ej5.Views;

public class ConsoleView
{
    private static readonly List<VehiculoViewModel> Vehiculos = Controlador.GetVehiculos();

    public static void DibujarMenu()
    {
        string? opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("                         Menú Principal - Empresa de Transporte                          ");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("Elija una opción:\n");
            Console.WriteLine("1. Listar vehículos");
            Console.WriteLine("2. Agregar vehículo");
            Console.WriteLine("3. Salir\n");
            Console.Write("Ingrese su opción: ");
            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                ListarVehiculos();
            }
            else if (opcion == "2")
            {
                Console.WriteLine("\nOpción no disponible en esta versión.");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }
        }
        while (opcion != "3");
    }

    private static void ListarVehiculos()
    {
        Console.Clear();
        Console.WriteLine("===============================================================================================================");
        Console.WriteLine("| {0,-10} | {1,-18} | {2,-11} | {3,10} | {4,6} | {5,5} | {6,7} | {7,14} |", 
            "Patente", "Vehículo", "Tipo", "Cap. Carga", "Km/l", "Año", "L.Extra", "Kms a recorrer");
        Console.WriteLine("===============================================================================================================");

        foreach (var v in Vehiculos)
        {
            Console.WriteLine("| {0,-10} | {1,-18} | {2,-11} | {3,10:N0} | {4,6:N0} | {5,5} | {6,7:N1} | {7,14:N0} |",
                v.GetPatente(),
                v.GetVehiculo().Length > 18 ? v.GetVehiculo()[..18] : v.GetVehiculo(),
                v.GetTipo(),
                v.GetCapacidadCarga(),
                v.GetKmPorLitro(),
                v.GetAnio(),
                v.GetLitrosExtra(),
                v.GetKmARecorrer());
        }

        Console.WriteLine("===============================================================================================================\n");
        Console.WriteLine("Presione una tecla para calcular el total de consumos...");
        Console.ReadKey();

        Dictionary<string, double> dictVehiculos = new();
        foreach (var vehiculo in Vehiculos)
        {
            dictVehiculos.Add(vehiculo.GetPatente(), vehiculo.GetKmARecorrer());
        }

        var (totalElectricos, totalCombustible) = Controlador.CalcularConsumos(dictVehiculos);

        Console.WriteLine("\n===============================================================================================================");
        Console.WriteLine($" Total consumo Vehículos Eléctricos   : {totalElectricos,8:F2} kWh");
        Console.WriteLine($" Total consumo Vehículos Combustible  : {totalCombustible,8:F2} Litros");
        Console.WriteLine("===============================================================================================================\n");

        Console.WriteLine("Presione una tecla para regresar al menú...");
        Console.ReadKey();
    }
}