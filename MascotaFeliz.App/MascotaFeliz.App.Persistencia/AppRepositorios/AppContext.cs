using Microsoft.EntityFrameworkCore;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public class AppContext : DbContext
    {
        //Conversión de Clases al SQL (DbSet)
        public DbSet<Agenda> Agendas {get; set;}
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<HistoriaClinica> HistoriasClinicas {get; set;}
        public DbSet<Mascota> Mascotas {get; set;}
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Vacuna> Vacunas {get; set;}
        public DbSet<Veterinario> Veterinarios {get; set;}
        public DbSet<VisitaDomiciliaria> VisitasDomiciliarias {get; set;}


        //Conexion al SQL
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=tcp:misiontic2022.database.windows.net,1433;Initial Catalog=HospiEncasatData;Persist Security Info=False;User ID=admin_01;Password=09122006_Hf;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=MascotaFelizBD;Trusted_Connection=True;");
            
            }
        }
        
    }
}