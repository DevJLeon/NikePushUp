using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("producto");

            builder.HasIndex(e => e.IdCategoria, "idCategoria");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            builder.Property(e => e.IdCategoria)
                .HasMaxLength(50)
                .HasColumnName("idCategoria");
            builder.Property(e => e.Imagen)
                .HasMaxLength(255)
                .HasColumnName("imagen");
            builder.Property(e => e.Precio).HasColumnName("precio");
            builder.Property(e => e.Stock).HasColumnName("stock");
            builder.Property(e => e.Titulo)
                .HasMaxLength(100)
                .HasColumnName("titulo");

            builder.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("producto_ibfk_1");
        }
    }