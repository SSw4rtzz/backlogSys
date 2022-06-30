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
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Equipa>().HasData(
            new Equipa { Id = 1, Nome = "Admintt", Email = "admintt@empresa.com", TeamLeader = 1, Chefe = 999 },
            new Equipa { Id = 2, Nome = "DevOps", Email = "devops@empresa.com", TeamLeader = 4, Chefe = 999 },
            new Equipa { Id = 3, Nome = "Aix System", Email = "aixs@empresa.com", TeamLeader = 7, Chefe = 998 },
            new Equipa { Id = 4, Nome = "Informática Interna", Email = "infint@empresa.com", TeamLeader = 9, Chefe = 997 }
            );

            modelBuilder.Entity<MembrosEquipa>().HasData(
            new MembrosEquipa { Id = 1, Nome = "Ana Silva", Email = "asilva@empresa.com", Efetividade="Sim", Foto = "asilva.jpg", EquipaFK=1  },
            new MembrosEquipa { Id = 2, Nome = "Bruno Sousa", Email = "bsousa@empresa.com", Efetividade = "Sim", Foto = "bsousa.jpg", EquipaFK = 1 },
            new MembrosEquipa { Id = 3, Nome = "César Pereira", Email = "cpereira@empresa.com", Efetividade = "Não", Foto = "cpereira.jpg", EquipaFK = 1 },
            new MembrosEquipa { Id = 4, Nome = "David Santos", Email = "dsantos@empresa.com", Efetividade = "Sim", Foto = "dsantos.jpg", EquipaFK = 2 },
            new MembrosEquipa { Id = 5, Nome = "Eurico Gonçalves", Email = "egonçalves@empresa.com", Efetividade = "Sim", Foto = "egonçalves.jpg", EquipaFK = 2 },
            new MembrosEquipa { Id = 6, Nome = "Francisca Pereira", Email = "fpereira@empresa.com", Efetividade = "Não", Foto = "cpereira.jpg", EquipaFK = 2 },
            new MembrosEquipa { Id = 7, Nome = "Gonçalo Santos", Email = "gsantos@empresa.com", Efetividade = "Sim", Foto = "dsantos.jpg", EquipaFK = 3 },
            new MembrosEquipa { Id = 8, Nome = "Hugo Oliveira", Email = "holiveira@empresa.com", Efetividade = "Sim", Foto = "egonçalves.jpg", EquipaFK = 3 },
            new MembrosEquipa { Id = 9, Nome = "Igor Pinheiro", Email = "ipinheiro@empresa.com", Efetividade = "Sim", Foto = "dsantos.jpg", EquipaFK = 4 },
            new MembrosEquipa { Id = 10, Nome = "Joana Marques", Email = "jmarques@empresa.com", Efetividade = "Não", Foto = "egonçalves.jpg", EquipaFK = 4 }
            );

            modelBuilder.Entity<Tarefas>().HasData(
            new Tarefas { Id = 1, Titulo = "Corrigir erro do formulário das tarefas, no BacklogSys", Descricao = "Corrigir erro do formulário das tarefas, este não está a enviar os dados para a base de dados como devia", PontoSituacao = "Por fazer", MembrosFK = 2, DataCriacao = DateTime.UtcNow, Prazo = DateTime.UtcNow, DataConclusao= DateTime.UtcNow },
            new Tarefas { Id = 2, Titulo = "FrontEnd Sistema de Logins", Descricao = "Criar interface para o sistema de logins", PontoSituacao = "Em desenvolvimento", MembrosFK = 2, DataCriacao = DateTime.UtcNow, Prazo = DateTime.UtcNow, DataConclusao = DateTime.UtcNow }

            );
        }


        // Definir as tabelas
        public DbSet<Tarefas> Tarefas { get; set; }
        public DbSet<MembrosEquipa> Membros { get; set; }
        public DbSet<Equipa> Equipa { get; set; }
    }
}
