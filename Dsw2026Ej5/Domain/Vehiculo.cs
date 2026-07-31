namespace Dsw2026Ej5.Domain;

public abstract class Vehiculo
{
    private string patente;
    private string marca;
    private string modelo;
    private int anio;
    private double capacidadCarga;
    private Sucursal sucursal;
    private VehiculoTipo tipo;

    protected Vehiculo(VehiculoTipo tipo, string patente, string marca, string modelo, int anio, double capacidadCarga, Sucursal sucursal)
    {
        this.patente = patente;
        this.marca = marca;
        this.modelo = modelo;
        this.anio = anio;
        this.capacidadCarga = capacidadCarga;
        this.sucursal = sucursal;
        this.tipo = tipo;
    }

    public string GetPatente() => patente;

    public string GetMarca() => marca;

    public string GetModelo() => modelo;

    public int GetAnio() => anio;

    public double GetCapacidadCarga() => capacidadCarga;

    public Sucursal GetSucursal() => sucursal;

    public VehiculoTipo GetTipo() => tipo;

    public abstract double CalcularConsumo(double kilometros);

    public bool EsDe(VehiculoTipo tipo) => this.tipo == tipo;

    public override string ToString() => $"{marca} {modelo}";
}
