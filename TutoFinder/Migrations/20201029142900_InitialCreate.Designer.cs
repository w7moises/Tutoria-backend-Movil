﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TutoFinder.Persistence;

namespace TutoFinder.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201029142900_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TutoFinder.Entity.Alumno", b =>
                {
                    b.Property<int>("AlumnoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("character varying(9)")
                        .HasMaxLength(9);

                    b.Property<string>("Grado_academico")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<int>("PadreId")
                        .HasColumnType("integer");

                    b.HasKey("AlumnoId");

                    b.HasIndex("PadreId");

                    b.ToTable("Alumnos");

                    b.HasData(
                        new
                        {
                            AlumnoId = 1,
                            Apellidos = "Cardenas",
                            Correo = "lucho13@gmail.com",
                            DNI = "75863340",
                            Grado_academico = "Secundaria",
                            Nombres = "Lucho",
                            PadreId = 1
                        });
                });

            modelBuilder.Entity("TutoFinder.Entity.Curso", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Grado_academico")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("character varying(30)")
                        .HasMaxLength(30);

                    b.HasKey("CursoId");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            CursoId = 1,
                            Descripcion = "aquellas herramientas que los usuarios pueden utilizar accediendo a un servidor web de internet",
                            Grado_academico = "Secundaria",
                            Nombre = "AplicacionesWeb"
                        });
                });

            modelBuilder.Entity("TutoFinder.Entity.Docente", b =>
                {
                    b.Property<int>("DocenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("character varying(9)")
                        .HasMaxLength(9);

                    b.Property<string>("Disponibilidad")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Domicilio")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Membresia")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Numero_cuenta")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.HasKey("DocenteId");

                    b.ToTable("Docentes");

                    b.HasData(
                        new
                        {
                            DocenteId = 1,
                            Apellidos = " Mendoza",
                            Correo = "henrry@gmail.com",
                            DNI = "16534786",
                            Disponibilidad = "No Disponible",
                            Domicilio = "San Miguel calle puquina los condominios la waka",
                            Membresia = "Activa",
                            Nombres = " Henrry",
                            Numero_cuenta = "2534586198371450"
                        });
                });

            modelBuilder.Entity("TutoFinder.Entity.Favorito", b =>
                {
                    b.Property<int>("FavoritoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("DocenteId")
                        .HasColumnType("integer");

                    b.Property<int>("PadreId")
                        .HasColumnType("integer");

                    b.HasKey("FavoritoId");

                    b.HasIndex("DocenteId");

                    b.HasIndex("PadreId");

                    b.ToTable("Favoritos");
                });

            modelBuilder.Entity("TutoFinder.Entity.Identity.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "c85b58f6-c236-4098-b5b5-a594f2c9ca3f",
                            ConcurrencyStamp = "87353879-4adf-43bc-ab15-f899363a4d59",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "7ae46fb8-3c00-4b69-8ffe-531a00768ab6",
                            ConcurrencyStamp = "881dfcf0-9bb9-4b1b-8197-3c35e77bf9e4",
                            Name = "PADRE",
                            NormalizedName = "PADRE"
                        },
                        new
                        {
                            Id = "187a6e25-705b-4919-be1d-bd336347c4b2",
                            ConcurrencyStamp = "2e0cc135-82f1-4035-9e73-6cc45a530dcb",
                            Name = "DOCENTE",
                            NormalizedName = "DOCENTE"
                        });
                });

            modelBuilder.Entity("TutoFinder.Entity.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("TutoFinder.Entity.Identity.ApplicationUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("TutoFinder.Entity.Informe", b =>
                {
                    b.Property<int>("InformeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<int>("TutoriaId")
                        .HasColumnType("integer");

                    b.HasKey("InformeId");

                    b.HasIndex("TutoriaId");

                    b.ToTable("Informes");

                    b.HasData(
                        new
                        {
                            InformeId = 1,
                            Descripcion = " no hizo nada en todo el ciclo",
                            Fecha = "12/02/2000",
                            TutoriaId = 1
                        });
                });

            modelBuilder.Entity("TutoFinder.Entity.Membresia", b =>
                {
                    b.Property<int>("MembresiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Cvc_tarjeta")
                        .IsRequired()
                        .HasColumnType("character varying(3)")
                        .HasMaxLength(3);

                    b.Property<int>("DocenteId")
                        .HasColumnType("integer");

                    b.Property<string>("Fecha_expiracion")
                        .IsRequired()
                        .HasColumnType("character varying(10)")
                        .HasMaxLength(10);

                    b.Property<int>("TarjetaId")
                        .HasColumnType("integer");

                    b.HasKey("MembresiaId");

                    b.HasIndex("DocenteId");

                    b.HasIndex("TarjetaId");

                    b.ToTable("Membresias");

                    b.HasData(
                        new
                        {
                            MembresiaId = 1,
                            Cvc_tarjeta = "123",
                            DocenteId = 1,
                            Fecha_expiracion = "12/05/2021",
                            TarjetaId = 1
                        });
                });

            modelBuilder.Entity("TutoFinder.Entity.Padre", b =>
                {
                    b.Property<int>("PadreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("character varying(9)")
                        .HasMaxLength(9);

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.HasKey("PadreId");

                    b.ToTable("Padres");

                    b.HasData(
                        new
                        {
                            PadreId = 1,
                            Apellidos = "Cahuana",
                            Correo = "Moieses@hotmail.com",
                            DNI = " 35826791",
                            Nombres = " Moises"
                        });
                });

            modelBuilder.Entity("TutoFinder.Entity.Pago", b =>
                {
                    b.Property<int>("PagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CvcTarjeta")
                        .IsRequired()
                        .HasColumnType("character varying(4)")
                        .HasMaxLength(4);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<int>("TarjetaId")
                        .HasColumnType("integer");

                    b.Property<int>("TutoriaId")
                        .HasColumnType("integer");

                    b.HasKey("PagoId");

                    b.HasIndex("TarjetaId");

                    b.HasIndex("TutoriaId");

                    b.ToTable("Pagos");

                    b.HasData(
                        new
                        {
                            PagoId = 1,
                            CvcTarjeta = "123",
                            Descripcion = " Pago de tutoria de redes",
                            TarjetaId = 1,
                            TutoriaId = 1
                        });
                });

            modelBuilder.Entity("TutoFinder.Entity.Tarjeta", b =>
                {
                    b.Property<int>("TarjetaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Fecha_expiracion")
                        .IsRequired()
                        .HasColumnType("character varying(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Nombre_poseedor")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Numero_tarjeta")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.HasKey("TarjetaId");

                    b.ToTable("Tarjetas");

                    b.HasData(
                        new
                        {
                            TarjetaId = 1,
                            Fecha_expiracion = "20/02/2025",
                            Nombre_poseedor = " Henry Papi",
                            Numero_tarjeta = "255.255.255.0"
                        });
                });

            modelBuilder.Entity("TutoFinder.Entity.Tutoria", b =>
                {
                    b.Property<int>("TutoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AlumnoId")
                        .HasColumnType("integer");

                    b.Property<int>("Cantidad_minutos")
                        .HasColumnType("integer");

                    b.Property<double>("Costo")
                        .HasColumnType("double precision");

                    b.Property<int>("CursoId")
                        .HasColumnType("integer");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<int>("DocenteId")
                        .HasColumnType("integer");

                    b.HasKey("TutoriaId");

                    b.HasIndex("AlumnoId");

                    b.HasIndex("CursoId");

                    b.HasIndex("DocenteId");

                    b.ToTable("Tutorias");

                    b.HasData(
                        new
                        {
                            TutoriaId = 1,
                            AlumnoId = 1,
                            Cantidad_minutos = 3,
                            Costo = 30.25,
                            CursoId = 1,
                            Descripcion = "Repaso de codigo Api",
                            DocenteId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("TutoFinder.Entity.Identity.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TutoFinder.Entity.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TutoFinder.Entity.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TutoFinder.Entity.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TutoFinder.Entity.Alumno", b =>
                {
                    b.HasOne("TutoFinder.Entity.Padre", "Padre")
                        .WithMany("Alumnos")
                        .HasForeignKey("PadreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TutoFinder.Entity.Favorito", b =>
                {
                    b.HasOne("TutoFinder.Entity.Docente", "Docente")
                        .WithMany()
                        .HasForeignKey("DocenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TutoFinder.Entity.Padre", "Padre")
                        .WithMany()
                        .HasForeignKey("PadreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TutoFinder.Entity.Identity.ApplicationUserRole", b =>
                {
                    b.HasOne("TutoFinder.Entity.Identity.ApplicationRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TutoFinder.Entity.Identity.ApplicationUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TutoFinder.Entity.Informe", b =>
                {
                    b.HasOne("TutoFinder.Entity.Tutoria", "Tutoria")
                        .WithMany()
                        .HasForeignKey("TutoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TutoFinder.Entity.Membresia", b =>
                {
                    b.HasOne("TutoFinder.Entity.Docente", "Docente")
                        .WithMany()
                        .HasForeignKey("DocenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TutoFinder.Entity.Tarjeta", "Tarjeta")
                        .WithMany()
                        .HasForeignKey("TarjetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TutoFinder.Entity.Pago", b =>
                {
                    b.HasOne("TutoFinder.Entity.Tarjeta", "Tarjeta")
                        .WithMany()
                        .HasForeignKey("TarjetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TutoFinder.Entity.Tutoria", "Tutoria")
                        .WithMany()
                        .HasForeignKey("TutoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TutoFinder.Entity.Tutoria", b =>
                {
                    b.HasOne("TutoFinder.Entity.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("AlumnoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TutoFinder.Entity.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TutoFinder.Entity.Docente", "Docente")
                        .WithMany("Tutorias")
                        .HasForeignKey("DocenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
