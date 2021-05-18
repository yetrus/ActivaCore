using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ActivaCore.Api.Models
{
    public partial class activaContext : DbContext
    {
        public activaContext()
        {
        }

        public activaContext(DbContextOptions<activaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppComuna> AppComuna { get; set; }
        public virtual DbSet<AppConfig> AppConfig { get; set; }
        public virtual DbSet<AppMenu> AppMenu { get; set; }
        public virtual DbSet<AppPerfil> AppPerfil { get; set; }
        public virtual DbSet<AppRegion> AppRegion { get; set; }
        public virtual DbSet<Archivo> Archivo { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Contacto> Contacto { get; set; }
        public virtual DbSet<Descuento> Descuento { get; set; }
        public virtual DbSet<DescuentoTipo> DescuentoTipo { get; set; }
        public virtual DbSet<Detalle> Detalle { get; set; }
        public virtual DbSet<DetalleTipo> DetalleTipo { get; set; }
        public virtual DbSet<Documento> Documento { get; set; }
        public virtual DbSet<DocumentoTipo> DocumentoTipo { get; set; }
        public virtual DbSet<Entidad> Entidad { get; set; }
        public virtual DbSet<EntidadTipo> EntidadTipo { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<EstadoEntidad> EstadoEntidad { get; set; }
        public virtual DbSet<EstadoRelacionLaboral> EstadoRelacionLaboral { get; set; }
        public virtual DbSet<Impuesto> Impuesto { get; set; }
        public virtual DbSet<ImpuestoTipo> ImpuestoTipo { get; set; }
        public virtual DbSet<Local> Local { get; set; }
        public virtual DbSet<LocalTipo> LocalTipo { get; set; }
        public virtual DbSet<Nave> Nave { get; set; }
        public virtual DbSet<Operacion> Operacion { get; set; }
        public virtual DbSet<OperacionTipo> OperacionTipo { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ProductoOperacionMap> ProductoOperacionMap { get; set; }
        public virtual DbSet<ProductoTipo> ProductoTipo { get; set; }
        public virtual DbSet<RelacionComercial> RelacionComercial { get; set; }
        public virtual DbSet<RelacionComercialTipo> RelacionComercialTipo { get; set; }
        public virtual DbSet<RelacionLaboral> RelacionLaboral { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<ServicioTipo> ServicioTipo { get; set; }
        public virtual DbSet<TblDepartment> TblDepartment { get; set; }
        public virtual DbSet<TblStudent> TblStudent { get; set; }
        public virtual DbSet<Tipo> Tipo { get; set; }
        public virtual DbSet<TipoArchivo> TipoArchivo { get; set; }

        // Unable to generate entity type for table 'dbo.App_EntidadPerfil_Map'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProductoFabricante'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Detalle_Descuento_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Documento_Descuento_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Documento_Impuesto_Map'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Entidad_RelacionComercial_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EntidadEstado_Map'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EntidadServicio_Map'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.servicio_tipo_map'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EntidadServicioProducto_Map'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Producto_Servicio_MAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProductoLocal_Map'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Entidad_tipo_map'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NaveServicio_Map'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.App_PerfilMenu_Map'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProductoCategoria_Map'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProductoDetalle_Map'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProductoEstado_Map'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Entidad_nave_map'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Relacion_laboral_entidad_map'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=activa;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<AppComuna>(entity =>
            {
                entity.HasKey(e => e.IdComuna)
                    .HasName("PK_AppComuna");

                entity.ToTable("App_Comuna");

                entity.Property(e => e.IdComuna).ValueGeneratedNever();

                entity.Property(e => e.CodigoArea).HasMaxLength(200);

                entity.Property(e => e.NombreComuna).HasMaxLength(500);

                entity.HasOne(d => d.IdRegionNavigation)
                    .WithMany(p => p.AppComuna)
                    .HasForeignKey(d => d.IdRegion)
                    .HasConstraintName("FK_AppComuna_AppRegion");
            });

            modelBuilder.Entity<AppConfig>(entity =>
            {
                entity.HasKey(e => e.IdConfig);

                entity.ToTable("App_config");

                entity.Property(e => e.IdConfig).HasColumnName("id_config");

                entity.Property(e => e.Config)
                    .HasColumnName("config")
                    .HasMaxLength(10);

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<AppMenu>(entity =>
            {
                entity.HasKey(e => e.IdMenu)
                    .HasName("PK_Menu");

                entity.ToTable("App_Menu");

                entity.Property(e => e.IdMenu).HasColumnName("Id_Menu");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdCabeceraMenu).HasColumnName("Id_cabecera_menu");

                entity.Property(e => e.IdCategoria).HasColumnName("Id_Categoria");

                entity.Property(e => e.Ruta)
                    .HasColumnName("ruta")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppPerfil>(entity =>
            {
                entity.HasKey(e => e.IdPerfil)
                    .HasName("PK_Perfil");

                entity.ToTable("App_Perfil");

                entity.Property(e => e.IdPerfil).HasColumnName("Id_Perfil");

                entity.Property(e => e.Descripcion).HasMaxLength(10);
            });

            modelBuilder.Entity<AppRegion>(entity =>
            {
                entity.HasKey(e => e.IdRegion)
                    .HasName("PK_AppRegion");

                entity.ToTable("App_Region");

                entity.Property(e => e.IdRegion).ValueGeneratedNever();

                entity.Property(e => e.NombreRegion).HasMaxLength(500);
            });

            modelBuilder.Entity<Archivo>(entity =>
            {
                entity.HasKey(e => e.IdArchivo);

                entity.Property(e => e.IdArchivo).HasColumnName("id_Archivo");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categoria__07F6335A");

                entity.HasIndex(e => e.IdCategoria)
                    .HasName("UQ__Categoria__08EA5793")
                    .IsUnique();

                entity.Property(e => e.IdCategoria).HasColumnName("Id_Categoria");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubCat).HasColumnName("Sub_Cat");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Categoria)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Categoria_Estado");
            });

            modelBuilder.Entity<Contacto>(entity =>
            {
                entity.HasKey(e => e.IdContacto);

                entity.Property(e => e.IdContacto).HasColumnName("Id_Contacto");

                entity.Property(e => e.IdEntidad).HasColumnName("Id_Entidad");

                entity.HasOne(d => d.IdEntidadNavigation)
                    .WithMany(p => p.ContactoNavigation)
                    .HasForeignKey(d => d.IdEntidad)
                    .HasConstraintName("FK_Contacto_Entidad");
            });

            modelBuilder.Entity<Descuento>(entity =>
            {
                entity.HasKey(e => e.IdDescuento)
                    .HasName("PK__Descuento__023D5A04");

                entity.HasIndex(e => e.IdDescuento)
                    .HasName("UQ__Descuento__03317E3D")
                    .IsUnique();

                entity.Property(e => e.IdDescuento).HasColumnName("Id_Descuento");

                entity.Property(e => e.Descuento1).HasColumnName("Descuento");

                entity.Property(e => e.IdTipo).HasColumnName("Id_Tipo");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Descuento)
                    .HasForeignKey(d => d.IdTipo)
                    .HasConstraintName("FK_Descuento_Descuento_tipo");
            });

            modelBuilder.Entity<DescuentoTipo>(entity =>
            {
                entity.HasKey(e => e.IdTipo);

                entity.ToTable("Descuento_tipo");

                entity.Property(e => e.IdTipo).HasColumnName("id_tipo");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Detalle>(entity =>
            {
                entity.HasKey(e => e.IdDetalle);

                entity.HasIndex(e => e.IdDetalle)
                    .HasName("UQ__Detalle__060DEAE8")
                    .IsUnique();

                entity.Property(e => e.IdDetalle).HasColumnName("Id_Detalle");

                entity.Property(e => e.IdCategoria).HasColumnName("Id_Categoria");

                entity.Property(e => e.IdDoc).HasColumnName("Id_Doc");

                entity.Property(e => e.IdEntidad).HasColumnName("Id_Entidad");

                entity.Property(e => e.IdEstado).HasColumnName("Id_Estado");

                entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");

                entity.Property(e => e.IdTipo).HasColumnName("Id_Tipo");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Detalle)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detalle_Categoria");

                entity.HasOne(d => d.IdDocNavigation)
                    .WithMany(p => p.Detalle)
                    .HasForeignKey(d => d.IdDoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detalle_Documento");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Detalle)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detalle_Estado");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.Detalle)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detalle_Producto");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Detalle)
                    .HasForeignKey(d => d.IdTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detalle_Detalle_tipo");
            });

            modelBuilder.Entity<DetalleTipo>(entity =>
            {
                entity.HasKey(e => e.IdTipo);

                entity.ToTable("Detalle_tipo");

                entity.Property(e => e.IdTipo).HasColumnName("id_tipo");

                entity.Property(e => e.TipoDescripcion)
                    .HasColumnName("tipo_descripcion")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Documento>(entity =>
            {
                entity.HasKey(e => e.IdDoc);

                entity.HasIndex(e => e.IdDoc)
                    .HasName("UQ__Documento__117F9D94")
                    .IsUnique();

                entity.Property(e => e.IdDoc).HasColumnName("Id_Doc");

                entity.Property(e => e.FechaDoc)
                    .HasColumnName("Fecha_Doc")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEstado).HasColumnName("Id_Estado");

                entity.Property(e => e.IdTipo).HasColumnName("Id_Tipo");

                entity.Property(e => e.SubDoc).HasColumnName("Sub_Doc");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Documento)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documento_Estado");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Documento)
                    .HasForeignKey(d => d.IdTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documento_Documento_tipo");
            });

            modelBuilder.Entity<DocumentoTipo>(entity =>
            {
                entity.HasKey(e => e.IdTipo);

                entity.ToTable("Documento_tipo");

                entity.Property(e => e.IdTipo).HasColumnName("Id_tipo");

                entity.Property(e => e.TipoDocumento)
                    .HasColumnName("Tipo_documento")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Entidad>(entity =>
            {
                entity.HasKey(e => e.IdEntidad);

                entity.HasIndex(e => e.IdEntidad)
                    .HasName("UQ__Entidad__00551192")
                    .IsUnique();

                entity.Property(e => e.IdEntidad).HasColumnName("Id_Entidad");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dv)
                    .HasColumnName("dv")
                    .HasMaxLength(1);

                entity.Property(e => e.Huella).HasMaxLength(5000);

                entity.Property(e => e.IdCategoria).HasColumnName("Id_Categoria");

                entity.Property(e => e.IdEmpresa).HasColumnName("Id_Empresa");

                entity.Property(e => e.IdEstado).HasColumnName("Id_Estado");

                entity.Property(e => e.IdSubTipo).HasColumnName("Id_SubTipo");

                entity.Property(e => e.IdTipo).HasColumnName("Id_Tipo");

                entity.Property(e => e.Mail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Materno).HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pass)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Razon)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Entidad)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK_Entidad_Categoria");

                entity.HasOne(d => d.IdComunaNavigation)
                    .WithMany(p => p.Entidad)
                    .HasForeignKey(d => d.IdComuna)
                    .HasConstraintName("FK_Entidad_AppComuna");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Entidad)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Entidad_Estado");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Entidad)
                    .HasForeignKey(d => d.IdTipo)
                    .HasConstraintName("FK_Entidad_Tipo");
            });

            modelBuilder.Entity<EntidadTipo>(entity =>
            {
                entity.HasKey(e => e.IdTipoEntidad);

                entity.ToTable("Entidad_tipo");

                entity.Property(e => e.IdTipoEntidad).HasColumnName("id_tipo_entidad");

                entity.Property(e => e.Tipo).HasMaxLength(100);
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PK__Estado__0DAF0CB0");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("UQ__Estado__0EA330E9")
                    .IsUnique();

                entity.Property(e => e.IdEstado).HasColumnName("Id_Estado");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadoEntidad>(entity =>
            {
                entity.HasKey(e => e.IdEstadoEntidad);

                entity.Property(e => e.IdEstadoEntidad)
                    .HasColumnName("idEstadoEntidad")
                    .ValueGeneratedNever();

                entity.Property(e => e.EstadoEntidad1)
                    .HasColumnName("EstadoEntidad")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EstadoRelacionLaboral>(entity =>
            {
                entity.HasKey(e => e.IdEstadoRelacionLaboral);

                entity.ToTable("estado_relacion_laboral");

                entity.Property(e => e.IdEstadoRelacionLaboral)
                    .HasColumnName("id_estado_relacion_laboral")
                    .ValueGeneratedNever();

                entity.Property(e => e.EstadoRelacionLaboral1)
                    .HasColumnName("estado_relacion_laboral")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Impuesto>(entity =>
            {
                entity.HasKey(e => e.IdImpuesto);

                entity.Property(e => e.IdImpuesto)
                    .HasColumnName("Id_impuesto")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdTipo).HasColumnName("Id_Tipo");

                entity.Property(e => e.NombreImpuesto)
                    .HasColumnName("Nombre_Impuesto")
                    .HasMaxLength(10);

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Impuesto)
                    .HasForeignKey(d => d.IdTipo)
                    .HasConstraintName("FK_Impuesto_Impuesto_tipo");
            });

            modelBuilder.Entity<ImpuestoTipo>(entity =>
            {
                entity.HasKey(e => e.IdTipoImpuesto);

                entity.ToTable("Impuesto_tipo");

                entity.Property(e => e.IdTipoImpuesto).HasColumnName("id_tipo_impuesto");

                entity.Property(e => e.TipoImpuesto)
                    .HasColumnName("tipo_impuesto")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Local>(entity =>
            {
                entity.HasKey(e => e.IdLocal)
                    .HasName("PK_Bodega");

                entity.Property(e => e.IdLocal).HasColumnName("Id_Local");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.IdLocalTipo).HasColumnName("Id_local_tipo");
            });

            modelBuilder.Entity<LocalTipo>(entity =>
            {
                entity.HasKey(e => e.IdLocalTipo);

                entity.ToTable("Local_tipo");

                entity.Property(e => e.IdLocalTipo)
                    .HasColumnName("Id_local_tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.TipoLocal)
                    .HasColumnName("Tipo_local")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Nave>(entity =>
            {
                entity.HasKey(e => e.IdNave);

                entity.Property(e => e.IdNave).HasColumnName("Id_Nave");
            });

            modelBuilder.Entity<Operacion>(entity =>
            {
                entity.HasKey(e => e.IdOperacion);

                entity.Property(e => e.IdOperacion).HasColumnName("Id_Operacion");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdDoc).HasColumnName("Id_Doc");

                entity.Property(e => e.IdEntidadDestino).HasColumnName("Id_Entidad_Destino");

                entity.Property(e => e.IdEntidadOrigen).HasColumnName("Id_Entidad_Origen");

                entity.Property(e => e.IdEstado).HasColumnName("Id_Estado");

                entity.Property(e => e.IdServicio).HasColumnName("Id_Servicio");

                entity.Property(e => e.IdTipo).HasColumnName("Id_Tipo");

                entity.HasOne(d => d.IdDocNavigation)
                    .WithMany(p => p.Operacion)
                    .HasForeignKey(d => d.IdDoc)
                    .HasConstraintName("FK_Operacion_Documento");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Operacion)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Operacion_Operacion");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.Operacion)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Operacion_Servicio");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Operacion)
                    .HasForeignKey(d => d.IdTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Operacion_operacion_tipo");
            });

            modelBuilder.Entity<OperacionTipo>(entity =>
            {
                entity.HasKey(e => e.IdOperacionTipo);

                entity.ToTable("operacion_tipo");

                entity.Property(e => e.IdOperacionTipo).HasColumnName("id_operacion_tipo");

                entity.Property(e => e.OperacionTipo1)
                    .HasColumnName("operacion_tipo")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.HasIndex(e => e.IdProducto)
                    .HasName("UQ__Producto__0BC6C43E")
                    .IsUnique();

                entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");

                entity.Property(e => e.Bodega).HasColumnName("bodega");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionLarga)
                    .HasColumnName("Descripcion_Larga")
                    .HasColumnType("text");

                entity.Property(e => e.IdEstado).HasColumnName("Id_Estado");

                entity.Property(e => e.IdLocal).HasColumnName("Id_Local");

                entity.Property(e => e.IdTipo).HasColumnName("Id_Tipo");

                entity.Property(e => e.NombreProducto)
                    .HasColumnName("Nombre_Producto")
                    .HasMaxLength(100);

                entity.Property(e => e.StockMax).HasColumnName("Stock_Max");

                entity.Property(e => e.StockMin).HasColumnName("Stock_Min");

                entity.Property(e => e.UnidadVenta).HasColumnName("Unidad_Venta");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Producto_Estado");

                entity.HasOne(d => d.IdLocalNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdLocal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Producto_Local");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Producto_Producto_tipo");
            });

            modelBuilder.Entity<ProductoOperacionMap>(entity =>
            {
                entity.HasKey(e => new { e.IdProducto, e.IdOperacion });

                entity.ToTable("Producto_Operacion_MAP");

                entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");

                entity.Property(e => e.IdOperacion).HasColumnName("Id_Operacion");

                entity.HasOne(d => d.IdOperacionNavigation)
                    .WithMany(p => p.ProductoOperacionMap)
                    .HasForeignKey(d => d.IdOperacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Producto_Operacion_MAP_Operacion");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.ProductoOperacionMap)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Producto_Operacion_MAP_Producto");
            });

            modelBuilder.Entity<ProductoTipo>(entity =>
            {
                entity.HasKey(e => e.IdTipo);

                entity.ToTable("Producto_tipo");

                entity.Property(e => e.IdTipo).HasColumnName("Id_tipo");

                entity.Property(e => e.TipoDescripcion)
                    .HasColumnName("tipo_descripcion")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<RelacionComercial>(entity =>
            {
                entity.HasKey(e => e.IdRelacionComercial);

                entity.Property(e => e.IdRelacionComercial).HasColumnName("ID_relacion_comercial");

                entity.Property(e => e.IdEstado).HasColumnName("Id_estado");

                entity.Property(e => e.IdTipoRelacion).HasColumnName("ID_tipo_relacion");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.RelacionComercial)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_RelacionComercial_Estado");

                entity.HasOne(d => d.IdTipoRelacionNavigation)
                    .WithMany(p => p.RelacionComercial)
                    .HasForeignKey(d => d.IdTipoRelacion)
                    .HasConstraintName("FK_RelacionComercial_Ralacion_comercial_tipo");
            });

            modelBuilder.Entity<RelacionComercialTipo>(entity =>
            {
                entity.HasKey(e => e.IdTipoRelacion)
                    .HasName("PK_Ralacion_comercial_tipo");

                entity.ToTable("Relacion_comercial_tipo");

                entity.Property(e => e.IdTipoRelacion).HasColumnName("id_tipo_relacion");

                entity.Property(e => e.TipoRelacion)
                    .HasColumnName("tipo_relacion")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<RelacionLaboral>(entity =>
            {
                entity.HasKey(e => e.IdRelacionLaboral);

                entity.Property(e => e.IdRelacionLaboral)
                    .HasColumnName("id_relacion_laboral")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdEstadoRelacionLaboral).HasColumnName("id_estado_relacion_laboral");

                entity.Property(e => e.RelacionLaboral1)
                    .HasColumnName("relacion_laboral")
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdEstadoRelacionLaboralNavigation)
                    .WithMany(p => p.RelacionLaboral)
                    .HasForeignKey(d => d.IdEstadoRelacionLaboral)
                    .HasConstraintName("FK_RelacionLaboral_estado_relacion_laboral");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.IdServicio);

                entity.Property(e => e.IdServicio).HasColumnName("Id_Servicio");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.IdEstado).HasColumnName("Id_estado");

                entity.Property(e => e.IdTipo).HasColumnName("Id_tipo");
            });

            modelBuilder.Entity<ServicioTipo>(entity =>
            {
                entity.HasKey(e => e.IdServicioTipo);

                entity.ToTable("servicio_tipo");

                entity.Property(e => e.IdServicioTipo).HasColumnName("id_servicio_tipo");

                entity.Property(e => e.ServicioTipo1)
                    .HasColumnName("Servicio_tipo")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("tblDepartment");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblStudent>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.ToTable("tblStudent");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.StudentName).HasMaxLength(50);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TblStudent)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_tblStudent_tblDepartment");
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK__Tipo_Doc__1367E606");

                entity.HasIndex(e => e.IdTipo)
                    .HasName("UQ__Tipo_Doc__145C0A3F")
                    .IsUnique();

                entity.Property(e => e.IdTipo).HasColumnName("Id_Tipo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdSubTipo).HasColumnName("Id_SubTipo");
            });

            modelBuilder.Entity<TipoArchivo>(entity =>
            {
                entity.HasKey(e => e.IdTipoArchivo);

                entity.Property(e => e.IdTipoArchivo).HasColumnName("Id_TipoArchivo");

                entity.Property(e => e.IdArchivo).HasColumnName("Id_Archivo");

                entity.Property(e => e.IdTipo).HasColumnName("Id_Tipo");

                entity.HasOne(d => d.IdArchivoNavigation)
                    .WithMany(p => p.TipoArchivo)
                    .HasForeignKey(d => d.IdArchivo)
                    .HasConstraintName("FK_TipoArchivo_Archivo");
            });
        }
    }
}
