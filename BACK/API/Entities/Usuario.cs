using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Rol> IdRolFks { get; set; } = new List<Rol>();
}
