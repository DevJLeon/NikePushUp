using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class Factura
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public float Total { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual ICollection<Productosventum> Productosventa { get; set; } = new List<Productosventum>();
}
