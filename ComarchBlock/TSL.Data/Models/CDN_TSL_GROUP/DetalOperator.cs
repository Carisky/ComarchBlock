using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DetalOperator
{
    public int DopeDopeId { get; set; }

    public int DopeDstaId { get; set; }

    public int DopeOpeId { get; set; }

    public virtual DetalStanowiska DopeDsta { get; set; } = null!;
}
