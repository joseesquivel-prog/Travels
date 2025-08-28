using System.ComponentModel.DataAnnotations;

namespace TravelApp.API.Models
{
    public class Ciudad
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;
    }
}