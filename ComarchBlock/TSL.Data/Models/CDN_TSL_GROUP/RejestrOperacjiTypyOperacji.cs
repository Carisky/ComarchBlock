using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class RejestrOperacjiTypyOperacji
{
    public int RoptopTyp { get; set; }

    public string RoptopNazwa { get; set; } = null!;

    public int RoptopJezyk { get; set; }
}
