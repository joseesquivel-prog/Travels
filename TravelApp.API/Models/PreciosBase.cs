using System.ComponentModel.DataAnnotations;

namespace TravelApp.API.Models
{
    public abstract class PreciosBase
    {
        public decimal PrecioPasaje { get; set; } = 50.00m;
        public decimal PrecioPaquete { get; set; } = 25.00m;
    }
}