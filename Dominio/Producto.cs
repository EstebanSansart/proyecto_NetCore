namespace Dominio;
public class Producto
{
    public int IdProducto { get; set; }
    public string RefProducto { get; set; }
    public string DescripcionProducto { get; set; }
    public int PrecioProducto { get; set; }
    public string DatoProducto { get; set; }
    public int IdMarca { get; set; }
    public Marca Marca { get; set; }
    public ICollection<PersonaProducto> PersonaProductos { get; set; }
}
