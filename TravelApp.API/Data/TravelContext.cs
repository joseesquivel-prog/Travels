using Microsoft.EntityFrameworkCore;
using TravelApp.API.Models;

namespace TravelApp.API.Data
{
    public class TravelContext : DbContext
    {
        public TravelContext(DbContextOptions<TravelContext> options) : base(options)
        {
        }

        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Pasaje> Pasajes { get; set; }
        public DbSet<Paquete> Paquetes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración para Ciudad
            modelBuilder.Entity<Ciudad>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nombre).IsRequired().HasMaxLength(100);
            });

            // Configuración para Pasaje
            modelBuilder.Entity<Pasaje>(entity =>
            {
                entity.HasKey(e => e.IdPasaje);
                entity.Property(e => e.PrecioPasaje).HasColumnType("decimal(18,2)");
            });

            // Configuración para Paquete
            modelBuilder.Entity<Paquete>(entity =>
            {
                entity.HasKey(e => e.IdPaquete);
                entity.Property(e => e.PrecioPaquete).HasColumnType("decimal(18,2)");
                entity.Property(e => e.Peso).HasColumnType("decimal(18,2)");
            });

            // Datos semilla para ciudades
            modelBuilder.Entity<Ciudad>().HasData(
                new Ciudad { Id = 1, Nombre = "Ciudad de México" },
                new Ciudad { Id = 2, Nombre = "Guadalajara" },
                new Ciudad { Id = 3, Nombre = "Monterrey" },
                new Ciudad { Id = 4, Nombre = "Cancún" },
                new Ciudad { Id = 5, Nombre = "Tijuana" },
                new Ciudad { Id = 6, Nombre = "Mérida" },
                new Ciudad { Id = 7, Nombre = "Puebla" },
                new Ciudad { Id = 8, Nombre = "León" }
            );
        }
    }
}