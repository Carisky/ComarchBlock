using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class DaneBinarneLinki
{
    public int DblDblid { get; set; }

    public int? DblDokumentTyp { get; set; }

    public int? DblDokumentId { get; set; }

    public int DblTwrId { get; set; }

    public int DblLp { get; set; }

    public int? DblTyp { get; set; }

    public string? DblNazwaPliku { get; set; }

    public string? DblSciezka { get; set; }

    public short? DblWbazie { get; set; }

    public int? DblDabId { get; set; }

    public short DblFileMode { get; set; }

    public short? DblEsklep { get; set; }

    public short DblJezykId { get; set; }

    public string DblTagLink { get; set; } = null!;

    public string DblTagAlt { get; set; } = null!;

    public byte DblTagRel { get; set; }

    public string DblTagTitle { get; set; } = null!;

    public Guid? DblESklepZalVerId { get; set; }

    public int? DblESklepJezykId { get; set; }
}
