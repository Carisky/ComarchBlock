using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class TraSvat
{
    public short TsvGidtyp { get; set; }

    public int? TsvGidfirma { get; set; }

    public int TsvGidnumer { get; set; }

    public short TsvGidlp { get; set; }

    public short TsvSubGidlp { get; set; }

    public decimal? TsvNettoR { get; set; }

    public decimal? TsvNettoP { get; set; }

    public decimal? TsvVatR { get; set; }

    public decimal? TsvVatP { get; set; }

    public short TsvDeklRok { get; set; }

    public short TsvDeklMiesiac { get; set; }

    public byte TsvRodzajZakupu { get; set; }

    public byte TsvOdliczeniaVat { get; set; }

    public byte TsvRozliczac { get; set; }

    public byte? TsvRozliczacP { get; set; }

    public string? TsvOpis { get; set; }

    public byte? TsvKatDatyOp { get; set; }

    public int? TsvDataOp { get; set; }

    public int? TsvDataPo { get; set; }

    public byte? TsvMetodaKasowa { get; set; }

    public int? TsvR2id { get; set; }

    public byte? TsvRozliczacViu { get; set; }

    public virtual TraVat TraVat { get; set; } = null!;
}
