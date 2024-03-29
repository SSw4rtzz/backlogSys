﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backlogSys.Data;

#nullable disable

namespace backlogSys.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220718140424_camposObrigatorios2")]
    partial class camposObrigatorios2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("backlogSys.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataRegisto")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("backlogSys.Models.Equipa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Chefe")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("TeamLeader")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Equipa");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Chefe = 999,
                            Email = "admintt@empresa.com",
                            Nome = "Admintt",
                            TeamLeader = 1
                        },
                        new
                        {
                            Id = 2,
                            Chefe = 999,
                            Email = "devops@empresa.com",
                            Nome = "DevOps",
                            TeamLeader = 4
                        },
                        new
                        {
                            Id = 3,
                            Chefe = 998,
                            Email = "aixs@empresa.com",
                            Nome = "Aix System",
                            TeamLeader = 7
                        },
                        new
                        {
                            Id = 4,
                            Chefe = 997,
                            Email = "infint@empresa.com",
                            Nome = "Informática Interna",
                            TeamLeader = 9
                        });
                });

            modelBuilder.Entity("backlogSys.Models.MembrosEquipa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Efetividade")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<int>("EquipaFK")
                        .HasColumnType("int");

                    b.Property<string>("Foto")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EquipaFK");

                    b.ToTable("Membros");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Efetividade = "Sim",
                            Email = "asilva@empresa.com",
                            EquipaFK = 1,
                            Foto = "asilva.jpg",
                            Nome = "Ana Silva"
                        },
                        new
                        {
                            Id = 2,
                            Efetividade = "Sim",
                            Email = "bsousa@empresa.com",
                            EquipaFK = 1,
                            Foto = "bsousa.jpg",
                            Nome = "Bruno Sousa"
                        },
                        new
                        {
                            Id = 3,
                            Efetividade = "Não",
                            Email = "cpereira@empresa.com",
                            EquipaFK = 1,
                            Foto = "cpereira.jpg",
                            Nome = "César Pereira"
                        },
                        new
                        {
                            Id = 4,
                            Efetividade = "Sim",
                            Email = "dsantos@empresa.com",
                            EquipaFK = 2,
                            Foto = "dsantos.jpg",
                            Nome = "David Santos"
                        },
                        new
                        {
                            Id = 5,
                            Efetividade = "Sim",
                            Email = "egonçalves@empresa.com",
                            EquipaFK = 2,
                            Foto = "egonçalves.jpg",
                            Nome = "Eurico Gonçalves"
                        },
                        new
                        {
                            Id = 6,
                            Efetividade = "Não",
                            Email = "fpereira@empresa.com",
                            EquipaFK = 2,
                            Foto = "cpereira.jpg",
                            Nome = "Francisca Pereira"
                        },
                        new
                        {
                            Id = 7,
                            Efetividade = "Sim",
                            Email = "gsantos@empresa.com",
                            EquipaFK = 3,
                            Foto = "dsantos.jpg",
                            Nome = "Gonçalo Santos"
                        },
                        new
                        {
                            Id = 8,
                            Efetividade = "Sim",
                            Email = "holiveira@empresa.com",
                            EquipaFK = 3,
                            Foto = "egonçalves.jpg",
                            Nome = "Hugo Oliveira"
                        },
                        new
                        {
                            Id = 9,
                            Efetividade = "Sim",
                            Email = "ipinheiro@empresa.com",
                            EquipaFK = 4,
                            Foto = "dsantos.jpg",
                            Nome = "Igor Pinheiro"
                        },
                        new
                        {
                            Id = 10,
                            Efetividade = "Não",
                            Email = "jmarques@empresa.com",
                            EquipaFK = 4,
                            Foto = "egonçalves.jpg",
                            Nome = "Joana Marques"
                        },
                        new
                        {
                            Id = 11,
                            Efetividade = "Sim",
                            Email = "mferreira@empresa.com",
                            EquipaFK = 4,
                            Foto = "null.png",
                            Nome = "Marina Ferreira"
                        });
                });

            modelBuilder.Entity("backlogSys.Models.Tarefas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataConclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<int?>("MembrosFK")
                        .HasColumnType("int");

                    b.Property<string>("PontoSituacao")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Prazo")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Prioridade")
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("MembrosFK");

                    b.ToTable("Tarefas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataConclusao = new DateTime(2022, 7, 18, 14, 4, 24, 515, DateTimeKind.Utc).AddTicks(2310),
                            DataCriacao = new DateTime(2022, 7, 18, 14, 4, 24, 515, DateTimeKind.Utc).AddTicks(2310),
                            Descricao = "Corrigir erro do formulário das tarefas, este não está a enviar os dados para a base de dados como devia",
                            MembrosFK = 2,
                            PontoSituacao = "Por fazer",
                            Prazo = new DateTime(2022, 7, 18, 14, 4, 24, 515, DateTimeKind.Utc).AddTicks(2310),
                            Titulo = "Corrigir erro do formulário das tarefas, no BacklogSys"
                        },
                        new
                        {
                            Id = 2,
                            DataConclusao = new DateTime(2022, 7, 18, 14, 4, 24, 515, DateTimeKind.Utc).AddTicks(2310),
                            DataCriacao = new DateTime(2022, 7, 18, 14, 4, 24, 515, DateTimeKind.Utc).AddTicks(2310),
                            Descricao = "Criar interface para o sistema de logins",
                            MembrosFK = 2,
                            PontoSituacao = "Em desenvolvimento",
                            Prazo = new DateTime(2022, 7, 18, 14, 4, 24, 515, DateTimeKind.Utc).AddTicks(2310),
                            Titulo = "FrontEnd Sistema de Logins"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "a",
                            ConcurrencyStamp = "db46c377-c2de-4d6d-b007-5dfd3458308b",
                            Name = "Administrativo",
                            NormalizedName = "ADMINISTRATIVO"
                        },
                        new
                        {
                            Id = "f",
                            ConcurrencyStamp = "4d7394e7-4f66-476d-a411-e88d179a7ce5",
                            Name = "Funcionario",
                            NormalizedName = "FUNCIONARIO"
                        },
                        new
                        {
                            Id = "c",
                            ConcurrencyStamp = "a1f63713-51aa-44da-b12f-4ff18deb79cd",
                            Name = "Chefe",
                            NormalizedName = "CHEFE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("backlogSys.Models.MembrosEquipa", b =>
                {
                    b.HasOne("backlogSys.Models.Equipa", "Equipa")
                        .WithMany("ListaMembros")
                        .HasForeignKey("EquipaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipa");
                });

            modelBuilder.Entity("backlogSys.Models.Tarefas", b =>
                {
                    b.HasOne("backlogSys.Models.MembrosEquipa", "Membros")
                        .WithMany("ListaTarefas")
                        .HasForeignKey("MembrosFK");

                    b.Navigation("Membros");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("backlogSys.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("backlogSys.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backlogSys.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("backlogSys.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("backlogSys.Models.Equipa", b =>
                {
                    b.Navigation("ListaMembros");
                });

            modelBuilder.Entity("backlogSys.Models.MembrosEquipa", b =>
                {
                    b.Navigation("ListaTarefas");
                });
#pragma warning restore 612, 618
        }
    }
}
