namespace Dominio.Entities;

public class Pais:EntityGenericB
{
    public ICollection<Region> Regiones { get; set; }

}
