using System;
using System.Collections.Generic;

namespace TallerMecanica.Models;

public partial class Cliente
{
    public int ClienteId { get; set; }

    public string? Nombre { get; set; }

    public string? CorreoElectronico { get; set; }

    public long? Telefono { get; set; }
}
