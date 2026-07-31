namespace Dsw2026Ej5.Domain;

public class Sucursal
{
    private string codigo;
    private string direccion;
    private string ciudad;
    private Responsable responsable;

    public Sucursal(string codigo, string direccion, string ciudad, Responsable responsable)
    {
        this.codigo = codigo;
        this.direccion = direccion;
        this.ciudad = ciudad;
        this.responsable = responsable;
    }

    public string GetCodigo() => codigo;

    public string GetDireccion() => direccion;

    public string GetCiudad() => ciudad;

    public Responsable GetResponsable() => responsable;
}
