using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoDatabaseFirst.Models;

//Sirve para indicar el nombre que tiene la tabla en la base de datos en caso de que en sqlServer
//por restricciones de la empresa se deban manejar nombres que no maneja Entity cuando hace el scaffolding
[Table("Pais")]
public partial class Pais
{
    public int IdPais { get; set; }

    public string NombrePais { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int ContinenteId { get; set; }

    public virtual ICollection<Ciudad> Ciudads { get; set; } = new List<Ciudad>();

    public virtual Continente Continente { get; set; } = null!;
}