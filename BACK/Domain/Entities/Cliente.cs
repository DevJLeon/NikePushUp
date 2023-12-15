using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Apellido { get; set; }

    public string? Telefono { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
