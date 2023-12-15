using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Productosventa
{
    public int Id { get; set; }

    public int? IdFactura { get; set; }

    public int? IdProducto { get; set; }

    public int Cantidad { get; set; }

    public float Subtotal { get; set; }

    public virtual Factura? IdFacturaNavigation { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }
}
