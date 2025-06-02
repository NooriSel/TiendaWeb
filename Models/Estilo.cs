using System.ComponentModel.DataAnnotations;

namespace TiendaWeb.Models
{
    public class Estilo
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre del estilo")]
        public string nombre { get; set; }
    }
}
