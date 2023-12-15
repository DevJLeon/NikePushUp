using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Categoria
{
    public string Id { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
