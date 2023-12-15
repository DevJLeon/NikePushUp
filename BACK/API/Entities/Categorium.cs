using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class Categorium
{
    public string Id { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
