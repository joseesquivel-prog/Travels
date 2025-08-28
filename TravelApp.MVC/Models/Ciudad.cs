using System.ComponentModel.DataAnnotations;

namespace TravelApp.MVC.Models
{
    public class Ciudad
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "El nombre de la ciudad es requerido")]
        [Display(Name = "Nombre de la Ciudad")]
        public string Nombre { get; set; } = string.Empty;
    }
}