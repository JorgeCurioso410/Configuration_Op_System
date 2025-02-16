using Microsoft.EntityFrameworkCore;
using System.DataAccess.FluentConfigurations.Entities;
using System.Dominio.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.DataAccess.Context
{
    public class ApplicationContext : DbContext
    {
        #region Tablas
        public DbSet<Fase> FaseList { get; set; }
        public DbSet<Operacion> OperacionList { get; set; }
        public DbSet<Receta> RecetaList { get; set; }
        #endregion
        
        private static DbContextOptions GetOptions(string connectionString)
        {
            return new DbContextOptionsBuilder().UseSqlite(connectionString).Options;
        }
        /// Para Migraciones
        public ApplicationContext() { }

        /// Inicializa un objeto ApplicationContext
        public ApplicationContext(string connectionString)
               : base(GetOptions(connectionString))
        {
        }
        /// inicializa un objeto ApplicationContext
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
              : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Fase>().ToTable("Fases");
            modelBuilder.Entity<Receta>().ToTable("Recetas");
            modelBuilder.Entity<Operacion>().ToTable("Operaciones");

            modelBuilder.ApplyConfiguration(new FaseEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OperacionEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RecetaEntityTypeConfiguration());
        }

    }
}

