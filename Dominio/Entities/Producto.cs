namespace Dominio.Entities;
public class Producto:EntityGenericA
{
    public string RefProducto { get; set; }
    public int PrecioProducto { get; set; }
    public string DatoProducto { get; set; }

    public int IdMarca { get; set; }
    public Marca Marca { get; set; }

    public ICollection<PersonaProducto> PersonaProductos { get; set; }
}
