using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class TraVat
{
    public short TrVGidtyp { get; set; }

    public int? TrVGidfirma { get; set; }

    public int TrVGidnumer { get; set; }

    public short TrVGidlp { get; set; }

    public decimal? TrVStawkaPod { get; set; }

    public byte? TrVFlagaVat { get; set; }

    public decimal? TrVZrodlowa { get; set; }

    public decimal? TrVNettoR { get; set; }

    public decimal? TrVNettoP { get; set; }

    public decimal? TrVVatR { get; set; }

    public decimal? TrVVatP { get; set; }

    public byte TrVExpoNorm { get; set; }

    public short TrVDeklRok { get; set; }

    public short TrVDeklMiesiac { get; set; }

    public byte TrVRodzajZakupu { get; set; }

    public byte TrVOdliczeniaVat { get; set; }

    public byte TrVRozliczac { get; set; }

    public decimal? TrVWartoscWal { get; set; }

    public byte TrVZaliczkowy { get; set; }

    public byte? TrVStruktura { get; set; }

    public byte? TrVRozliczacP { get; set; }

    public short? TrVSrtTyp { get; set; }

    public int? TrVSrtFirma { get; set; }

    public int? TrVSrtNumer { get; set; }

    public short? TrVSrtLp { get; set; }

    public int? TrVUlrid { get; set; }

    public int? TrVRknid { get; set; }

    public byte? TrVRkstrona { get; set; }

    public int? TrVOgraniczenieOdl { get; set; }

    public string? TrVOpis { get; set; }

    public int? TrVShenumer { get; set; }

    public short? TrVShelp { get; set; }

    public byte? TrVKatDatyOp { get; set; }

    public int? TrVDataOp { get; set; }

    public int? TrVDataPo { get; set; }

    public byte? TrVVatnalOd { get; set; }

    public int? TrVKntNumer { get; set; }

    public int? TrVKnAnumer { get; set; }

    public byte? TrVKorektaDanych { get; set; }

    public byte? TrVRozliczacViu { get; set; }

    public virtual ICollection<TraSvat> TraSvats { get; set; } = new List<TraSvat>();
}
