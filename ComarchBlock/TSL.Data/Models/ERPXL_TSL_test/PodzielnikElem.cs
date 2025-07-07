using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class PodzielnikElem
{
    public short? PdeGidtyp { get; set; }

    public int? PdeGidfirma { get; set; }

    public int PdeGidnumer { get; set; }

    public int PdeGidlp { get; set; }

    public short? PdePrcTyp { get; set; }

    public int? PdePrcFirma { get; set; }

    public int? PdePrcNumer { get; set; }

    public short? PdePrcLp { get; set; }

    public decimal? PdeDni { get; set; }

    public decimal? PdeProcent { get; set; }

    public short? PdeKierunek { get; set; }

    public byte? PdeTyp { get; set; }

    public byte? PdeZatwierdzono { get; set; }

    public virtual PodzielnikNag PdeGidnumerNavigation { get; set; } = null!;

    public virtual ICollection<PodzielnikSelem> PodzielnikSelems { get; set; } = new List<PodzielnikSelem>();
}
