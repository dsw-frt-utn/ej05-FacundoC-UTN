namespace Dsw2026Ej5.Domain;

public class VehiculoElectrico : Vehiculo
{
    private double kwhBase;

    public VehiculoElectrico(string patente, string marca, string modelo, int anio, double capacidadCarga,
        Sucursal sucursal, double kwhBase) : base(VehiculoTipo.Electrico, patente, marca, modelo, anio, capacidadCarga, sucursal)
    {
        this.kwhBase = kwhBase;
    }

    public double GetKwhBase() => kwhBase;

    public override double CalcularConsumo(double kilometros)
    {
        double total = (kilometros / 100.0) * kwhBase;

        if (GetCapacidadCarga() > 1200)
        {
            total *= 1.15;
        }

        return total;
    }
}