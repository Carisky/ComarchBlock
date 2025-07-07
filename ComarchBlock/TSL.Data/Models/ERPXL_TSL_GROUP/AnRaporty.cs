using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class AnRaporty
{
    public short? AnRGidtyp { get; set; }

    public int? AnRGidfirma { get; set; }

    public int AnRGidnumer { get; set; }

    public short? AnRGidlp { get; set; }

    public short? AnROpeTyp { get; set; }

    public int? AnROpeFirma { get; set; }

    public int? AnROpeNumer { get; set; }

    public short? AnROpeLp { get; set; }

    public short? AnRGw1typ { get; set; }

    public int? AnRGw1firma { get; set; }

    public int? AnRGw1numer { get; set; }

    public short? AnRGw1lp { get; set; }

    public short? AnRGw2typ { get; set; }

    public int? AnRGw2firma { get; set; }

    public int? AnRGw2numer { get; set; }

    public short? AnRGw2lp { get; set; }

    public string? AnRAkronim { get; set; }

    public int? AnRIloscArch { get; set; }

    public int? AnRKiedyNowy { get; set; }

    public short? AnRKiedyLiczyc { get; set; }

    public int? AnRDaneZ { get; set; }

    public int? AnRDataOd { get; set; }

    public int? AnRTypOd { get; set; }

    public int? AnRDataDo { get; set; }

    public int? AnRTypDo { get; set; }

    public string? AnRFiltr { get; set; }

    public string? AnRQuery { get; set; }

    public byte? AnRAktywny { get; set; }

    public byte? AnRPriorytet { get; set; }

    public string? AnROpis { get; set; }

    public virtual ICollection<AnFunkcje> AnFunkcjes { get; set; } = new List<AnFunkcje>();

    public virtual ICollection<AnKolejka> AnKolejkas { get; set; } = new List<AnKolejka>();
}
