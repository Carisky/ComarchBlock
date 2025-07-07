using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class UmwVat
{
    public short? UmVGidtyp { get; set; }

    public int? UmVGidfirma { get; set; }

    public int UmVGidnumer { get; set; }

    public short UmVGidlp { get; set; }

    public string? UmVGrupaPod { get; set; }

    public decimal? UmVStawkaPod { get; set; }

    public short? UmVFlagaVat { get; set; }

    public decimal? UmVNetto { get; set; }

    public decimal? UmVBrutto { get; set; }

    public decimal? UmVVat { get; set; }

    public string? UmVWaluta { get; set; }

    public short? UmVNrKursu { get; set; }

    public decimal? UmVKursM { get; set; }

    public decimal? UmVKursL { get; set; }

    public virtual UmwNag UmVGidnumerNavigation { get; set; } = null!;
}
