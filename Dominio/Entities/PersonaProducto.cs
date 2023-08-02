using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
public class PersonaProducto
{
    [Key]
    public int IdPersona { get; set; }
    public Persona Persona { get; set; }
    
    [Key]
    public int IdProducto { get; set; }
    public Producto Producto { get; set; }
}