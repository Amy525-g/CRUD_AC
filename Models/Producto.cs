using System.ComponentModel.DataAnnotations;

namespace CRUD_AC.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Range(0.01, 9999.99)]
        public double Precio { get; set; }
        public int Stock { get; set; }
    }
}
