using System.ComponentModel.DataAnnotations;

namespace TravelApp.API.Models
{
    public class Paquete : PreciosBase
    {
        [Key]
        public int IdPaquete { get; set; }
        
        [Required]
        [StringLength(50)]
        public string NombreRemitente { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)]
        public string ApellidoRemitente { get; set; } = string.Empty;
        
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string CorreoRemitente { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)]
        public string NombreDestinatario { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)]
        public string ApellidoDestinatario { get; set; } = string.Empty;
        
        [Required]
        [StringLength(100)]
        public string Origen { get; set; } = string.Empty;
        
        [Required]
        [StringLength(100)]
        public string Destino { get; set; } = string.Empty;
        
        [Range(0.1, 50.0)]
        public decimal Peso { get; set; }
        
        [StringLength(500)]
        public string Descripcion { get; set; } = string.Empty;
        
        public DateTime FechaEnvio { get; set; }
        
        public DateTime FechaEntregaEstimada { get; set; }
        
        [StringLength(20)]
        public string Estado { get; set; } = "Pendiente";

        public decimal CostoTotal()
        {
            return Peso * PrecioPaquete;
        }
    }
}