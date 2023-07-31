namespace Dominio;
public class Region
{
    public int IdRegion { get; set; }
    public string Descripcion { get; set; }
    public int IdPais { get; set; }
    public Pais Pais { get; set; }
    public ICollection<Provincia> Provincia { get; set; }

}
