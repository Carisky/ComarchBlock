using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class SeSkwoty
{
    public short? SkwGidtyp { get; set; }

    public int? SkwGidfirma { get; set; }

    public int SkwGidnumer { get; set; }

    public short SkwGidlp { get; set; }

    public string SkwPcn { get; set; } = null!;

    public decimal? SkwWartoscPozycji { get; set; }

    public decimal SkwStawkaCla { get; set; }

    public decimal? SkwPodstawaCla { get; set; }

    public decimal? SkwKwotaCla { get; set; }

    public decimal SkwStawkaAkcyzy { get; set; }

    public decimal? SkwPodstawaAkcyzy { get; set; }

    public decimal? SkwKwotaAkcyzy { get; set; }

    public string SkwGrupaPod { get; set; } = null!;

    public decimal SkwStawkaPod { get; set; }

    public byte? SkwFlagaVat { get; set; }

    public decimal? SkwZrodlowa { get; set; }

    public decimal? SkwPodstawaVat { get; set; }

    public decimal? SkwKwotaVat { get; set; }

    public string SkwKrajPoch { get; set; } = null!;

    public string? SkwPreferencje { get; set; }

    public int? SkwMasaNetto { get; set; }

    public int? SkwIloscJmuzup { get; set; }

    public int? SkwId { get; set; }

    public string? SkwOpisTowaru { get; set; }

    public virtual ICollection<SeSkwotyDod> SeSkwotyDods { get; set; } = new List<SeSkwotyDod>();

    public virtual SadNag SkwGidnumerNavigation { get; set; } = null!;
}
