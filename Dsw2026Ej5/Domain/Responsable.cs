namespace Dsw2026Ej5.Domain;

public class Responsable
{
    private string nombre;
    private string documento;
    private string telefono;

    public Responsable(string nombre, string documento, string telefono)
    {
        this.nombre = nombre;
        this.documento = documento;
        this.telefono = telefono;
    }

    public string GetNombre() => nombre;

    public string GetDocumento() => documento;

    public string GetTelefono() => telefono;
}
