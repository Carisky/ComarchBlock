using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class PdoczynnosciKraje
{
    public int PdockId { get; set; }

    public int? PdockPdocid { get; set; }

    public string? PdockKraj { get; set; }

    public int? PdockUzasadnienieId { get; set; }

    public virtual Pdoczynnosci? PdockPdoc { get; set; }
}
