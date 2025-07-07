using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PodElemDokVat
{
    public int PevPonnumer { get; set; }

    public short PevPedlp { get; set; }

    public short PevLp { get; set; }

    public decimal? PevStawkaPod { get; set; }

    public short? PevFlagaVat { get; set; }

    public byte? PevStruktura { get; set; }

    public byte? PevRodzajZakupu { get; set; }

    public byte? PevOdliczeniaVat { get; set; }

    public byte? PevExpoNorm { get; set; }

    public decimal? PevNetto { get; set; }

    public decimal? PevVat { get; set; }

    public virtual PodElemDok PodElemDok { get; set; } = null!;
}
