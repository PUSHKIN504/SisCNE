﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using CNE.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CNE.DataAccess.Context
{
    public partial class ConsejonacionalelectoralContext : DbContext
    {
        public ConsejonacionalelectoralContext()
        {
        }

        public ConsejonacionalelectoralContext(DbContextOptions<ConsejonacionalelectoralContext> options)
            : base(options)
        {
        }

        public virtual DbSet<tbAlcaldes> tbAlcaldes { get; set; }
        public virtual DbSet<tbCentrosVotaciones> tbCentrosVotaciones { get; set; }
        public virtual DbSet<tbDepartamentos> tbDepartamentos { get; set; }
        public virtual DbSet<tbDiputados> tbDiputados { get; set; }
        public virtual DbSet<tbEmpleados> tbEmpleados { get; set; }
        public virtual DbSet<tbEstadosCiviles> tbEstadosCiviles { get; set; }
        public virtual DbSet<tbMesas> tbMesas { get; set; }
        public virtual DbSet<tbMunicipios> tbMunicipios { get; set; }
        public virtual DbSet<tbPantallas> tbPantallas { get; set; }
        public virtual DbSet<tbPantallasPorRoles> tbPantallasPorRoles { get; set; }
        public virtual DbSet<tbPartidos> tbPartidos { get; set; }
        public virtual DbSet<tbPersonas> tbPersonas { get; set; }
        public virtual DbSet<tbPresidentes> tbPresidentes { get; set; }
        public virtual DbSet<tbRoles> tbRoles { get; set; }
        public virtual DbSet<tbUsuarios> tbUsuarios { get; set; }
        public virtual DbSet<tbVotos> tbVotos { get; set; }
        public virtual DbSet<tbVotosPorDiputados> tbVotosPorDiputados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<tbAlcaldes>(entity =>
            {
                entity.HasKey(e => e.Alc_Id)
                    .HasName("PK__tbAlcald__88844579CAAC0372");

                entity.ToTable("tbAlcaldes", "Vota");

                entity.Property(e => e.Alc_Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Alc_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Alc_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Alc_ImgUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Alc_Votos).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Alc)
                    .WithOne(p => p.tbAlcaldes)
                    .HasForeignKey<tbAlcaldes>(d => d.Alc_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tbAlcaldes_tbPersonas_Alc_Id");

                entity.HasOne(d => d.Alc_UsuarioCreacionNavigation)
                    .WithMany(p => p.tbAlcaldesAlc_UsuarioCreacionNavigation)
                    .HasForeignKey(d => d.Alc_UsuarioCreacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbMesas_tbUsuarios_Alc_UsuarioCreacion");

                entity.HasOne(d => d.Alc_UsuarioModificacionNavigation)
                    .WithMany(p => p.tbAlcaldesAlc_UsuarioModificacionNavigation)
                    .HasForeignKey(d => d.Alc_UsuarioModificacion)
                    .HasConstraintName("FK_tbMesas_tbUsuarios_Alc_UsuarioModificacion");

                entity.HasOne(d => d.Par)
                    .WithMany(p => p.tbAlcaldes)
                    .HasForeignKey(d => d.Par_id);
            });

            modelBuilder.Entity<tbCentrosVotaciones>(entity =>
            {
                entity.HasKey(e => e.CeV_Id)
                    .HasName("PK__tbCentro__D3F47733FBC6CBA7");

                entity.ToTable("tbCentrosVotaciones", "Vota");

                entity.Property(e => e.CeV_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.CeV_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Mun_Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.CeV_UsuarioCreacionNavigation)
                    .WithMany(p => p.tbCentrosVotacionesCeV_UsuarioCreacionNavigation)
                    .HasForeignKey(d => d.CeV_UsuarioCreacion)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CeV_UsuarioModificacionNavigation)
                    .WithMany(p => p.tbCentrosVotacionesCeV_UsuarioModificacionNavigation)
                    .HasForeignKey(d => d.CeV_UsuarioModificacion)
                    .HasConstraintName("FK_tbCentrosVotaciones_tbUsuarios_UsuarioModificacion");

                entity.HasOne(d => d.Mun)
                    .WithMany(p => p.tbCentrosVotaciones)
                    .HasForeignKey(d => d.Mun_Id);
            });

            modelBuilder.Entity<tbDepartamentos>(entity =>
            {
                entity.HasKey(e => e.Dep_Id)
                    .HasName("PK_tbDepartamentos_Depar_Id");

                entity.ToTable("tbDepartamentos", "Gral");

                entity.Property(e => e.Dep_Id)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Dep_Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Dep_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Dep_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.Dep_UsuarioCreacionNavigation)
                    .WithMany(p => p.tbDepartamentosDep_UsuarioCreacionNavigation)
                    .HasForeignKey(d => d.Dep_UsuarioCreacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbDepartamentos_tbUsuarios_Depar_UsuarioCreacion");

                entity.HasOne(d => d.Dep_UsuarioModificacionNavigation)
                    .WithMany(p => p.tbDepartamentosDep_UsuarioModificacionNavigation)
                    .HasForeignKey(d => d.Dep_UsuarioModificacion)
                    .HasConstraintName("FK_tbDepartamentos_tbUsuarios_Depar_UsuarioModificacion");
            });

            modelBuilder.Entity<tbDiputados>(entity =>
            {
                entity.HasKey(e => e.Dip_Id)
                    .HasName("PK__tbDiputa__C40DD8E614DEDA82");

                entity.ToTable("tbDiputados", "Vota");

                entity.Property(e => e.Dip_Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Dip_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Dip_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Dip_ImgUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dip_Votos).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Dip)
                    .WithOne(p => p.tbDiputados)
                    .HasForeignKey<tbDiputados>(d => d.Dip_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tbDiputados_tbPersonas_Dip_Id");

                entity.HasOne(d => d.Dip_UsuarioCreacionNavigation)
                    .WithMany(p => p.tbDiputadosDip_UsuarioCreacionNavigation)
                    .HasForeignKey(d => d.Dip_UsuarioCreacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbMesas_tbUsuarios_Dip_UsuarioCreacion");

                entity.HasOne(d => d.Dip_UsuarioModificacionNavigation)
                    .WithMany(p => p.tbDiputadosDip_UsuarioModificacionNavigation)
                    .HasForeignKey(d => d.Dip_UsuarioModificacion)
                    .HasConstraintName("FK_tbMesas_tbUsuarios_Dip_UsuarioModificacion");

                entity.HasOne(d => d.Par)
                    .WithMany(p => p.tbDiputados)
                    .HasForeignKey(d => d.Par_id);
            });

            modelBuilder.Entity<tbEmpleados>(entity =>
            {
                entity.HasKey(e => e.Per_Id)
                    .HasName("PK_tbEmpleados_Per_Id");

                entity.ToTable("tbEmpleados", "Vota");

                entity.Property(e => e.Per_Id).ValueGeneratedNever();

                entity.Property(e => e.Emp_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Emp_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.Emp_UsuarioCreacionNavigation)
                    .WithMany(p => p.tbEmpleadosEmp_UsuarioCreacionNavigation)
                    .HasForeignKey(d => d.Emp_UsuarioCreacion)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Emp_UsuarioModificacionNavigation)
                    .WithMany(p => p.tbEmpleadosEmp_UsuarioModificacionNavigation)
                    .HasForeignKey(d => d.Emp_UsuarioModificacion);

                entity.HasOne(d => d.Per)
                    .WithOne(p => p.tbEmpleados)
                    .HasForeignKey<tbEmpleados>(d => d.Per_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tbEmpleados_tbPersonas_Per_Id");
            });

            modelBuilder.Entity<tbEstadosCiviles>(entity =>
            {
                entity.HasKey(e => e.EsC_Id)
                    .HasName("PK_tbEstadosCiviles_EsC_Id");

                entity.ToTable("tbEstadosCiviles", "Gral");

                entity.Property(e => e.EsC_Descripcion)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.EsC_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.EsC_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.EsC_UsuarioCreacionNavigation)
                    .WithMany(p => p.tbEstadosCivilesEsC_UsuarioCreacionNavigation)
                    .HasForeignKey(d => d.EsC_UsuarioCreacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbEstadosCiviles_tbUsuarios_Estad_UsuarioCreacion");

                entity.HasOne(d => d.EsC_UsuarioModificacionNavigation)
                    .WithMany(p => p.tbEstadosCivilesEsC_UsuarioModificacionNavigation)
                    .HasForeignKey(d => d.EsC_UsuarioModificacion)
                    .HasConstraintName("FK_tbEstadosCiviles_tbUsuarios_Estad_UsuarioModificacion");
            });

            modelBuilder.Entity<tbMesas>(entity =>
            {
                entity.HasKey(e => e.Mes_Id)
                    .HasName("PK__tbMesas__6936283CB6DE5383");

                entity.ToTable("tbMesas", "Vota");

                entity.Property(e => e.Mes_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Mes_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.CeV)
                    .WithMany(p => p.tbMesas)
                    .HasForeignKey(d => d.CeV_Id)
                    .HasConstraintName("FK_tbMesas_tbCentrosVotaciones_Par_id");

                entity.HasOne(d => d.Mes_Custodio1Navigation)
                    .WithMany(p => p.tbMesasMes_Custodio1Navigation)
                    .HasForeignKey(d => d.Mes_Custodio1)
                    .HasConstraintName("FK_tbMesas_tbPersonas_Mes_Custodio1");

                entity.HasOne(d => d.Mes_Custodio2Navigation)
                    .WithMany(p => p.tbMesasMes_Custodio2Navigation)
                    .HasForeignKey(d => d.Mes_Custodio2)
                    .HasConstraintName("FK_tbMesas_tbPersonas_Mes_Custodio2");

                entity.HasOne(d => d.Mes_JuradoNavigation)
                    .WithMany(p => p.tbMesasMes_JuradoNavigation)
                    .HasForeignKey(d => d.Mes_Jurado)
                    .HasConstraintName("FK_tbMesas_tbPersonas_Mes_Jurado");

                entity.HasOne(d => d.Mes_UsuarioCreacionNavigation)
                    .WithMany(p => p.tbMesasMes_UsuarioCreacionNavigation)
                    .HasForeignKey(d => d.Mes_UsuarioCreacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbMesas_tbUsuarios_CeV_UsuarioCreacion");

                entity.HasOne(d => d.Mes_UsuarioModificacionNavigation)
                    .WithMany(p => p.tbMesasMes_UsuarioModificacionNavigation)
                    .HasForeignKey(d => d.Mes_UsuarioModificacion)
                    .HasConstraintName("FK_tbMesas_tbUsuarios_UsuarioModificacion");
            });

            modelBuilder.Entity<tbMunicipios>(entity =>
            {
                entity.HasKey(e => e.Mun_Id)
                    .HasName("PK_tbMunicipios_Munic_Id");

                entity.ToTable("tbMunicipios", "Gral");

                entity.Property(e => e.Mun_Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Dep_Id)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Mun_Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mun_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Mun_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.Dep)
                    .WithMany(p => p.tbMunicipios)
                    .HasForeignKey(d => d.Dep_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbMunicipios_tbDepartamentos_Depar_Id");

                entity.HasOne(d => d.Mun_UsuarioCreacionNavigation)
                    .WithMany(p => p.tbMunicipiosMun_UsuarioCreacionNavigation)
                    .HasForeignKey(d => d.Mun_UsuarioCreacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbMunicipios_tbUsuarios_Munic_UsuarioCreacion");

                entity.HasOne(d => d.Mun_UsuarioModificacionNavigation)
                    .WithMany(p => p.tbMunicipiosMun_UsuarioModificacionNavigation)
                    .HasForeignKey(d => d.Mun_UsuarioModificacion)
                    .HasConstraintName("FK_tbMunicipios_tbUsuarios_Munic_UsuarioModificacion");
            });

            modelBuilder.Entity<tbPantallas>(entity =>
            {
                entity.HasKey(e => e.Panta_Id)
                    .HasName("PK_tbPantallas_Panta_Id");

                entity.ToTable("tbPantallas", "Acce");

                entity.Property(e => e.Panta_Descripcion)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Panta_Esquema)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Panta_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Panta_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Panta_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.Panta_UsuarioCreacionNavigation)
                    .WithMany(p => p.tbPantallasPanta_UsuarioCreacionNavigation)
                    .HasForeignKey(d => d.Panta_UsuarioCreacion)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Panta_UsuarioModificacionNavigation)
                    .WithMany(p => p.tbPantallasPanta_UsuarioModificacionNavigation)
                    .HasForeignKey(d => d.Panta_UsuarioModificacion);
            });

            modelBuilder.Entity<tbPantallasPorRoles>(entity =>
            {
                entity.HasKey(e => e.Papro_Id)
                    .HasName("PK_tbPantallasPorRoles_Paxro_Id");

                entity.ToTable("tbPantallasPorRoles", "Acce");

                entity.Property(e => e.Papro_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Papro_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Papro_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.Panta)
                    .WithMany(p => p.tbPantallasPorRoles)
                    .HasForeignKey(d => d.Panta_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Papro_UsuarioCreacionNavigation)
                    .WithMany(p => p.tbPantallasPorRolesPapro_UsuarioCreacionNavigation)
                    .HasForeignKey(d => d.Papro_UsuarioCreacion)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Papro_UsuarioModificacionNavigation)
                    .WithMany(p => p.tbPantallasPorRolesPapro_UsuarioModificacionNavigation)
                    .HasForeignKey(d => d.Papro_UsuarioModificacion);

                entity.HasOne(d => d.Roles)
                    .WithMany(p => p.tbPantallasPorRoles)
                    .HasForeignKey(d => d.Roles_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<tbPartidos>(entity =>
            {
                entity.HasKey(e => e.Par_id)
                    .HasName("PK__tbPartid__620575A68C666257");

                entity.ToTable("tbPartidos", "Vota");

                entity.Property(e => e.Par_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Par_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Par_ImgUrl).IsUnicode(false);

                entity.Property(e => e.Par_Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Par_UsuarioCreacionNavigation)
                    .WithMany(p => p.tbPartidosPar_UsuarioCreacionNavigation)
                    .HasForeignKey(d => d.Par_UsuarioCreacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbMesas_tbUsuarios_Par_UsuarioCreacion");

                entity.HasOne(d => d.Par_UsuarioModificacionNavigation)
                    .WithMany(p => p.tbPartidosPar_UsuarioModificacionNavigation)
                    .HasForeignKey(d => d.Par_UsuarioModificacion)
                    .HasConstraintName("FK_tbMesas_tbUsuarios_Par_UsuarioModificacion");
            });

            modelBuilder.Entity<tbPersonas>(entity =>
            {
                entity.HasKey(e => e.Per_Id)
                    .HasName("PK_tbPersonas_Perso_Id");

                entity.ToTable("tbPersonas", "Gral");

                entity.Property(e => e.Mun_Id)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Per_Apellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Per_CedulaIdentidad).HasMaxLength(13);

                entity.Property(e => e.Per_Direccion).IsRequired();

                entity.Property(e => e.Per_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Per_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Per_FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Per_Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Per_Sexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Per_Telefono)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Per_Voto).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.EsC)
                    .WithMany(p => p.tbPersonas)
                    .HasForeignKey(d => d.EsC_Id)
                    .HasConstraintName("fk_tbVotante_tbEstadosCiviles_EsC_Id");

                entity.HasOne(d => d.Mes)
                    .WithMany(p => p.tbPersonas)
                    .HasForeignKey(d => d.Mes_Id);

                entity.HasOne(d => d.Mun)
                    .WithMany(p => p.tbPersonas)
                    .HasForeignKey(d => d.Mun_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tbVotante_tbMunicipios_Munic_Id");

                entity.HasOne(d => d.Per_UsuarioCreacionNavigation)
                    .WithMany(p => p.tbPersonasPer_UsuarioCreacionNavigation)
                    .HasForeignKey(d => d.Per_UsuarioCreacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbPersonas_tbUsuarios_Perso_UsuarioCreacion");

                entity.HasOne(d => d.Per_UsuarioModificacionNavigation)
                    .WithMany(p => p.tbPersonasPer_UsuarioModificacionNavigation)
                    .HasForeignKey(d => d.Per_UsuarioModificacion)
                    .HasConstraintName("FK_tbPersonas_tbUsuarios_Perso_UsuarioModificacion");
            });

            modelBuilder.Entity<tbPresidentes>(entity =>
            {
                entity.HasKey(e => e.Pre_Id)
                    .HasName("PK__tbPresid__1973A594C7E8E381");

                entity.ToTable("tbPresidentes", "Vota");

                entity.Property(e => e.Pre_Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Pre_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Pre_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Pre_ImgUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pre_Votos).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Par)
                    .WithMany(p => p.tbPresidentes)
                    .HasForeignKey(d => d.Par_id)
                    .HasConstraintName("FK_tbAlcaldes_tbPresidentes_Par_id");

                entity.HasOne(d => d.Pre)
                    .WithOne(p => p.tbPresidentes)
                    .HasForeignKey<tbPresidentes>(d => d.Pre_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tbPresidentes_tbPersonas_Pre_Id");

                entity.HasOne(d => d.Pre_UsuarioCreacionNavigation)
                    .WithMany(p => p.tbPresidentesPre_UsuarioCreacionNavigation)
                    .HasForeignKey(d => d.Pre_UsuarioCreacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbMesas_tbUsuarios_Pre_UsuarioCreacion");

                entity.HasOne(d => d.Pre_UsuarioModificacionNavigation)
                    .WithMany(p => p.tbPresidentesPre_UsuarioModificacionNavigation)
                    .HasForeignKey(d => d.Pre_UsuarioModificacion)
                    .HasConstraintName("FK_tbMesas_tbUsuarios_Pre_UsuarioModificacion");
            });

            modelBuilder.Entity<tbRoles>(entity =>
            {
                entity.HasKey(e => e.Roles_Id)
                    .HasName("PK_tbRoles_Roles_Id");

                entity.ToTable("tbRoles", "Acce");

                entity.Property(e => e.Roles_Descripcion)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Roles_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Roles_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Roles_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.Roles_UsuarioCreacionNavigation)
                    .WithMany(p => p.tbRolesRoles_UsuarioCreacionNavigation)
                    .HasForeignKey(d => d.Roles_UsuarioCreacion)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Roles_UsuarioModificacionNavigation)
                    .WithMany(p => p.tbRolesRoles_UsuarioModificacionNavigation)
                    .HasForeignKey(d => d.Roles_UsuarioModificacion);
            });

            modelBuilder.Entity<tbUsuarios>(entity =>
            {
                entity.HasKey(e => e.Usuar_Id)
                    .HasName("PK_tbUsuarios_Usuar_Id");

                entity.ToTable("tbUsuarios", "Acce");

                entity.Property(e => e.Usuar_Admin).HasDefaultValueSql("((0))");

                entity.Property(e => e.Usuar_Contrasena).IsRequired();

                entity.Property(e => e.Usuar_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Usuar_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Usuar_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Usuar_UltimaSesion).HasColumnType("datetime");

                entity.Property(e => e.Usuar_Usuario)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Per)
                    .WithMany(p => p.tbUsuarios)
                    .HasForeignKey(d => d.Per_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Usuar_UsuarioCreacionNavigation)
                    .WithMany(p => p.InverseUsuar_UsuarioCreacionNavigation)
                    .HasForeignKey(d => d.Usuar_UsuarioCreacion);

                entity.HasOne(d => d.Usuar_UsuarioModificacionNavigation)
                    .WithMany(p => p.InverseUsuar_UsuarioModificacionNavigation)
                    .HasForeignKey(d => d.Usuar_UsuarioModificacion);
            });

            modelBuilder.Entity<tbVotos>(entity =>
            {
                entity.HasKey(e => e.Vot_Id)
                    .HasName("PK__tbVotos__6E9302D5D9464A10");

                entity.ToTable("tbVotos", "Vota");

                entity.HasOne(d => d.Alc)
                    .WithMany(p => p.tbVotos)
                    .HasForeignKey(d => d.Alc_Id);

                entity.HasOne(d => d.Mes)
                    .WithMany(p => p.tbVotos)
                    .HasForeignKey(d => d.Mes_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tbVotos_tbMesas_Mes_Mesa");

                entity.HasOne(d => d.Pre)
                    .WithMany(p => p.tbVotos)
                    .HasForeignKey(d => d.Pre_Id);
            });

            modelBuilder.Entity<tbVotosPorDiputados>(entity =>
            {
                entity.HasKey(e => e.VpD_Id)
                    .HasName("pk_tbVotosPorDiputados_VpD_Id");

                entity.ToTable("tbVotosPorDiputados", "Vota");

                entity.HasOne(d => d.Dip)
                    .WithMany(p => p.tbVotosPorDiputados)
                    .HasForeignKey(d => d.Dip_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Vot)
                    .WithMany(p => p.tbVotosPorDiputados)
                    .HasForeignKey(d => d.Vot_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tbVotosPorDiputados_tbVotos_Mes_Mesa");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}