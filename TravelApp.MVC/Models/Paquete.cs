using System.ComponentModel.DataAnnotations;

namespace TravelApp.MVC.Models
{
    public class Paquete
    {
        public int IdPaquete { get; set; }
        
        [Required(ErrorMessage = "El nombre del remitente es requerido")]
        [Display(Name = "Nombre del Remitente")]
        public string NombreRemitente { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "El apellido del remitente es requerido")]
        [Display(Name = "Apellido del Remitente")]
        public string ApellidoRemitente { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "El correo del remitente es requerido")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido")]
        [Display(Name = "Correo del Remitente")]
        public string CorreoRemitente { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "El nombre del destinatario es requerido")]
        [Display(Name = "Nombre del Destinatario")]
        public string NombreDestinatario { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "El apellido del destinatario es requerido")]
        [Display(Name = "Apellido del Destinatario")]
        public string ApellidoDestinatario { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "El origen es requerido")]
        [Display(Name = "Ciudad de Origen")]
        public string Origen { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "El destino es requerido")]
        [Display(Name = "Ciudad de Destino")]
        public string Destino { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "El peso es requerido")]
        [Range(0.1, 50.0, ErrorMessage = "El peso debe estar entre 0.1 y 50 kg")]
        [Display(Name = "Peso (kg)")]
        public decimal Peso { get; set; }
        
        [Display(Name = "Descripción del Contenido")]
        public string Descripcion { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "La fecha de envío es requerida")]
        [Display(Name = "Fecha de Envío")]
        [DataType(DataType.Date)]
        public DateTime FechaEnvio { get; set; }
        
        [Display(Name = "Fecha de Entrega Estimada")]
        [DataType(DataType.Date)]
        public DateTime FechaEntregaEstimada { get; set; }
        
        [Display(Name = "Estado")]
        public string Estado { get; set; } = "Pendiente";

        public decimal PrecioPaquete { get; set; } = 25.00m;

        public decimal CostoTotal()
        {
            return Peso * PrecioPaquete;
        }
    }
}