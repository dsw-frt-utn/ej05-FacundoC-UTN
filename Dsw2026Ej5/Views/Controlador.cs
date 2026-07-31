using Dsw2026Ej5.Data;
using Dsw2026Ej5.Domain;

namespace Dsw2026Ej5.Views;

public class Controlador
{
    public static List<VehiculoViewModel> GetVehiculos()
    {
        List<VehiculoViewModel> vehiculos = new();
        foreach (Vehiculo vehiculo in Persistencia.GetVehiculos())
        {
            vehiculos.Add(new VehiculoViewModel(vehiculo));
        }
        return vehiculos;
    }

    public static (double, double) CalcularConsumos(Dictionary<string, double> vehiculos)
    {
        double consumoElectricos = 0;
        double consumoCombustible = 0;

        foreach (var (patente, kilometros) in vehiculos)
        {
            Vehiculo? vehiculo = Persistencia.GetVehiculo(patente);
            if (vehiculo != null)
            {
                double consumo = vehiculo.CalcularConsumo(kilometros);
                if (vehiculo.EsDe(VehiculoTipo.Electrico))
                {
                    consumoElectricos += consumo;
                }
                else if (vehiculo.EsDe(VehiculoTipo.Combustible))
                {
                    consumoCombustible += consumo;
                }
            }
        }

        return (consumoElectricos, consumoCombustible);
    }
}
