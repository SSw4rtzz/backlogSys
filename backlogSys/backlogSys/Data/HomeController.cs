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


        // definir as tabelas
        public DbSet<Tarefas> Tarefas { get; set; }
        public DbSet<MembrosEq> Membros { get; set; }
        public DbSet<Equipa> Equipa { get; set; }


    }
}
