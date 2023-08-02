namespace Dominio.Entities;
public class Persona:EntityGenericB
{
    public string ApellidoPersona { get; set; }
    public int EdadPersona { get; set; }

    public int IdProv { get; set; }
    public Provincia Provincia { get; set; }

    public int IdTipoPer { get;  set; }
    public TipoPersona TipoPersona { get; set; }

    public ICollection<PersonaProducto> PersonaProductos { get; set; }
}