using System;
using System.Collections.Generic;

namespace TallerMecanica.Models;

public partial class Vehiculo
{
    public int VehiculoId { get; set; }

    public string? Placa { get; set; }

    public string? Marca { get; set; }

    public string? Color { get; set; }
}
