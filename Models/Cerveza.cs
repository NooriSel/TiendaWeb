using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaWeb.Models
{
    public class Cerveza
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Ingresa el Nombre de la cerveza")]
        [Display(Name = "Nombre de la cerveza")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Ingresa el porcentaje de alcohol")]
        [Display(Name = "% de Alcohol")]
        public double alcohol { get; set; }
        [Display(Name = "Estilo")]
        public int idEstilo { get; set; }
        [ForeignKey("idEstilo")]
        public Estilo? Estilo { get; set; }
        [Required(ErrorMessage = "Ingresa el Precio")]
        [Display(Name = "Precio")]
        public double precio { get; set; }
        [Display(Name = "Imagen")]
        public string? UrlImagen { get; set; }
    }
}
