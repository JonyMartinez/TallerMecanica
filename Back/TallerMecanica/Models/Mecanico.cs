using System;
using System.Collections.Generic;

namespace TallerMecanica.Models;

public partial class Mecanico
{
    public int MecanicoId { get; set; }

    public string? Nombre { get; set; }

    public string? CorreoElectronico { get; set; }

    public long? Telefono { get; set; }
}
