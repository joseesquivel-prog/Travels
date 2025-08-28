using System.ComponentModel.DataAnnotations;

namespace TravelApp.API.Models
{
    public class Pasaje : PreciosBase
    {
        [Key]
        public int IdPasaje { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Nombres { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; } = string.Empty;
        
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Correo { get; set; } = string.Empty;
        
        [Range(1, 10)]
        public int CanAsientos { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Origen { get; set; } = string.Empty;
        
        [Required]
        [StringLength(100)]
        public string Destino { get; set; } = string.Empty;
        
        public DateTime FechaSalida { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Horario { get; set; } = string.Empty;

        public Pasaje()
        {
        }

        public Pasaje(string nombre, string apellido, string correo, int canAsiento, string origen, string destino,
            DateTime fechaSalida, string horario)
        {
            Nombres = nombre;
            Apellidos = apellido;
            Correo = correo;
            CanAsientos = canAsiento;
            Origen = origen;
            Destino = destino;
            FechaSalida = fechaSalida;
            Horario = horario;
        }

        public decimal CostoTotal()
        {
            return CanAsientos * PrecioPasaje;
        }
    }
}