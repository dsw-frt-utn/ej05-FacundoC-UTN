using Dsw2026Ej5.Domain;

namespace Dsw2026Ej5.Views;

public class VehiculoViewModel
{
    private string patente = string.Empty;
    private string vehiculo = string.Empty;
    private string tipo = string.Empty;
    private string sucursal = string.Empty;
    private double capacidadCarga;
    private double kmPorLitro;
    private int anio;
    private double litrosExtra;
    private double kmARecorrer;

    public VehiculoViewModel(Vehiculo vehiculo)
    {
        if (vehiculo == null) return;

        this.patente = vehiculo.GetPatente();
        this.vehiculo = vehiculo.ToString();
        this.tipo = vehiculo.GetTipo().ToString();
        this.sucursal = vehiculo.GetSucursal().GetCodigo();
        this.capacidadCarga = vehiculo.GetCapacidadCarga();
        this.anio = vehiculo.GetAnio();
        this.kmPorLitro = vehiculo is VehiculoCombustible combustible ? combustible.GetKilometrosPorLitro() : 0;
        this.litrosExtra = vehiculo is VehiculoCombustible combustible1 ? combustible1.GetLitrosExtra() : 0;
        this.kmARecorrer = 100;
    }

    public string GetPatente() => patente;

    public string GetVehiculo() => vehiculo;

    public string GetTipo() => tipo;

    public string GetSucursal() => sucursal;

    public double GetCapacidadCarga() => capacidadCarga;

    public double GetKmPorLitro() => kmPorLitro;

    public int GetAnio() => anio;

    public double GetLitrosExtra() => litrosExtra;

    public double GetKmARecorrer() => kmARecorrer;

    public void SetKmARecorrer(double km)
    {
        this.kmARecorrer = km;
    }
}
