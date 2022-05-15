using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

using backlogSys.Models;

namespace backlogSys.Data {

    /// <summary>
    /// Base de dados
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<MembrosEq>().HasData(
            new MembrosEq { Id = 1, Nome = "José Lopes", Email = "Vet-8768", Efetividade="Sim", Foto = "Jose.jpg"  }
            );
        }


        // Definir as tabelas
        public DbSet<Tarefas> Tarefas { get; set; }
        public DbSet<MembrosEq> Membros { get; set; }
        public DbSet<Equipa> Equipa { get; set; }


    }
}
