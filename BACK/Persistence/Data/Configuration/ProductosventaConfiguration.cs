using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class ProductosventaConfiguration : IEntityTypeConfiguration<Productosventa>
    {
        public void Configure(EntityTypeBuilder<Productosventa> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("productosventa");

            builder.HasIndex(e => e.IdFactura, "idFactura");

            builder.HasIndex(e => e.IdProducto, "idProducto");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            builder.Property(e => e.Cantidad).HasColumnName("cantidad");
            builder.Property(e => e.IdFactura).HasColumnName("idFactura");
            builder.Property(e => e.IdProducto).HasColumnName("idProducto");
            builder.Property(e => e.Subtotal).HasColumnName("subtotal");

            builder.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.Productosventa)
                .HasForeignKey(d => d.IdFactura)
                .HasConstraintName("productosventa_ibfk_1");

            builder.HasOne(d => d.IdProductoNavigation).WithMany(p => p.Productosventa)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("productosventa_ibfk_2");
        }
    }