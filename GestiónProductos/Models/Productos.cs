using System.ComponentModel.DataAnnotations;

namespace GestiónProductos.Models
{
    public class Productos
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo nombre es obligatorio")]
        public string Nombre { get; set; }
        
        [Required(ErrorMessage = "El campo categoria es obligatorio")]
        public string Categoria { get; set; }
        
        [Required(ErrorMessage = "El campo precio es obligatorio")]
        public decimal Precio { get; set; }
        
        public bool Disponible { get; set; }
    }
}
