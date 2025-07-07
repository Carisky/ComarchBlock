using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ZamVat
{
    public short? ZaVGidtyp { get; set; }

    public int? ZaVGidfirma { get; set; }

    public int ZaVGidnumer { get; set; }

    public short? ZaVGidlp { get; set; }

    public decimal ZaVStawkaPod { get; set; }

    public byte ZaVFlagaVat { get; set; }

    public decimal? ZaVNetto { get; set; }

    public decimal? ZaVBrutto { get; set; }

    public decimal? ZaVVat { get; set; }

    public string ZaVWaluta { get; set; } = null!;

    public short? ZaVNrKursu { get; set; }

    public decimal? ZaVKursM { get; set; }

    public decimal? ZaVKursL { get; set; }

    public virtual ZamNag ZaVGidnumerNavigation { get; set; } = null!;
}
