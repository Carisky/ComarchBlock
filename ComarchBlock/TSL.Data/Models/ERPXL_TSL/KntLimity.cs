using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class KntLimity
{
    public short? KlsKntTyp { get; set; }

    public int? KlsKntFirma { get; set; }

    public int KlsKntNumer { get; set; }

    public short? KlsKntLp { get; set; }

    public int KlsFrsId { get; set; }

    public decimal? KlsKwotaLimitu { get; set; }

    public virtual FrmStruktura KlsFrs { get; set; } = null!;
}
