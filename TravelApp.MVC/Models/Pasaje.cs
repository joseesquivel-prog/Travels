using System.ComponentModel.DataAnnotations;

namespace TravelApp.MVC.Models
{
    public class Pasaje
    {
        public int IdPasaje { get; set; }
        
        [Required(ErrorMessage = "Los nombres son requeridos")]
        [Display(Name = "Nombres")]
        public string Nombres { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Los apellidos son requeridos")]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "El correo es requerido")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido")]
        [Display(Name = "Correo Electrónico")]
        public string Correo { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "La cantidad de asientos es requerida")]
        [Range(1, 10, ErrorMessage = "La cantidad de asientos debe estar entre 1 y 10")]
        [Display(Name = "Cantidad de Asientos")]
        public int CanAsientos { get; set; }
        
        [Required(ErrorMessage = "El origen es requerido")]
        [Display(Name = "Ciudad de Origen")]
        public string Origen { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "El destino es requerido")]
        [Display(Name = "Ciudad de Destino")]
        public string Destino { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "La fecha de salida es requerida")]
        [Display(Name = "Fecha de Salida")]
        [DataType(DataType.Date)]
        public DateTime FechaSalida { get; set; }
        
        [Required(ErrorMessage = "El horario es requerido")]
        [Display(Name = "Horario")]
        public string Horario { get; set; } = string.Empty;

        public decimal PrecioPasaje { get; set; } = 50.00m;

        public decimal CostoTotal()
        {
            return CanAsientos * PrecioPasaje;
        }
    }
}