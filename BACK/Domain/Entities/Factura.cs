using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Factura
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public float Total { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual ICollection<Productosventa> Productosventa { get; set; } = new List<Productosventa>();
}
