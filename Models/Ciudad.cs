using System.ComponentModel.DataAnnotations;


namespace Web.Api.Models
{
    public class Ciudad
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
