using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class PodzielnikNag
{
    public short? PdnGidtyp { get; set; }

    public int? PdnGidfirma { get; set; }

    public int PdnGidnumer { get; set; }

    public int? PdnGidlp { get; set; }

    public string? PdnOpis { get; set; }

    public byte? PdnZatwierdzono { get; set; }

    public short? PdnDniRobocze { get; set; }

    public int? PdnData { get; set; }

    public int? PdnDataDo { get; set; }

    public byte? PdnUdostepniaj { get; set; }

    public string? PdnJm { get; set; }

    public int? PdnTstampAkt { get; set; }

    public short? PdnOpeTypA { get; set; }

    public int? PdnOpeFirmaA { get; set; }

    public int? PdnOpeNumerA { get; set; }

    public short? PdnOpeLpA { get; set; }

    public int? PdnTstampZ { get; set; }

    public short? PdnOpeTypZ { get; set; }

    public int? PdnOpeFirmaZ { get; set; }

    public int? PdnOpeNumerZ { get; set; }

    public short? PdnOpeLpZ { get; set; }

    public virtual ICollection<PodzielnikElem> PodzielnikElems { get; set; } = new List<PodzielnikElem>();

    public virtual ICollection<PodzielnikMelem> PodzielnikMelems { get; set; } = new List<PodzielnikMelem>();

    public virtual ICollection<PodzielnikPrac> PodzielnikPracs { get; set; } = new List<PodzielnikPrac>();

    public virtual ICollection<PodzielnikZelem> PodzielnikZelems { get; set; } = new List<PodzielnikZelem>();
}
