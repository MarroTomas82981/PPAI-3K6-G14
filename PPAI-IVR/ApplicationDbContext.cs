using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PPAI_IVR.Clases;
using PPAI_IVR.Models.Clases;

namespace PPAI_IVR
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Llamada> Llamadas { get; set; }
        public DbSet<CambioEstado> CambiosDeEstado { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<SubOpcionLlamada> SubOpcionLlamadas { get; set; }
        public DbSet<InformacionCliente> InformacionClientes { get; set; }
        public DbSet<Validacion> ValidacionClientes { get;set; }
        public DbSet<CategoriaLlamada> CategoriaLlamadas { get;set; }
        public DbSet<OpcionLlamada> OpcionLlamadas { get; set; } 
    }
}
