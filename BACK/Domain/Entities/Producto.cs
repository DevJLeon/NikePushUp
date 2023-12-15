using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Producto
{
    public int Id { get; set; }

    public string? IdCategoria { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Imagen { get; set; }

    public float Precio { get; set; }

    public int Stock { get; set; }

    public virtual Categoria? IdCategoriaNavigation { get; set; }

    public virtual ICollection<Productosventa> Productosventa { get; set; } = new List<Productosventa>();
}
