using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class Producto
{
    public int Id { get; set; }

    public string? IdCategoria { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Imagen { get; set; }

    public float Precio { get; set; }

    public int Stock { get; set; }

    public virtual Categorium? IdCategoriaNavigation { get; set; }

    public virtual ICollection<Productosventum> Productosventa { get; set; } = new List<Productosventum>();
}
