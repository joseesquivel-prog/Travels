using System.ComponentModel.DataAnnotations;

namespace Web.Api.Models
{
    public class Pasaje:PreciosBase
    {
        [Key]
        public int idPasaje { get; set; }
        public string Nombres { get;  set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public int CanAsientos { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public  DateTime FechaSalida { get; set; }
        public string Horario { get; set; }

        public Pasaje()
        {
            
        }

        public Pasaje(string nombre,string apellido, string correo, int canAsiento, string origen, string destino,
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
