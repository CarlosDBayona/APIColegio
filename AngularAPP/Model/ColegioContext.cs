using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TaskColegio.Model
{
    public partial class ColegioContext : DbContext
    {
        public ColegioContext()
        {
        }

        public ColegioContext(DbContextOptions<ColegioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\;Database=Colegio;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("Alumno_pk")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.Id)
                    .HasName("Alumno_Id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellido)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("Curso_pk")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.IdAlumno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdMateria)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAlumnoNavigation)
                    .WithMany(p => p.Curso)
                    .HasForeignKey(d => d.IdAlumno)
                    .HasConstraintName("Curso_Alumno_Id_fk");

                entity.HasOne(d => d.IdMateriaNavigation)
                    .WithMany(p => p.Curso)
                    .HasForeignKey(d => d.IdMateria)
                    .HasConstraintName("Curso_Materia_IdMateria_fk");
            });

            modelBuilder.Entity<Materia>(entity =>
            {
                entity.HasKey(e => e.IdMateria)
                    .HasName("Materia_pk")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.IdMateria)
                    .HasName("Materia_IdMateria_uindex")
                    .IsUnique();

                entity.Property(e => e.IdMateria)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.IdProfesor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Profesor>(entity =>
            {
                entity.HasKey(e => e.Cedula)
                    .HasName("Profesor_pk")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.Cedula)
                    .HasName("Profesor_Cedula_uindex")
                    .IsUnique();

                entity.Property(e => e.Cedula)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}
