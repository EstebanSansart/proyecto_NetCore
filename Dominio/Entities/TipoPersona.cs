namespace Dominio.Entities;
public class TipoPersona:EntityGenericA
{
    public ICollection<Persona> Personas { get; set; }
}
