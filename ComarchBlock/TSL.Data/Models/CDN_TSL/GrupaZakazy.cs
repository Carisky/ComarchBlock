using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class GrupaZakazy
{
    public int GrZGrZid { get; set; }

    public int GrZGruId { get; set; }

    public int GrZOpeId { get; set; }

    public virtual Grupy GrZGru { get; set; } = null!;
}
