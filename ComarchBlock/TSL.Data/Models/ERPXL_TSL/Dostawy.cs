using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class Dostawy
{
    public short? DstGidtyp { get; set; }

    public int? DstGidfirma { get; set; }

    public int DstGidnumer { get; set; }

    public short? DstGidlp { get; set; }

    public short? DstTrnTyp { get; set; }

    public int? DstTrnFirma { get; set; }

    public int? DstTrnNumer { get; set; }

    public short? DstTrnLp { get; set; }

    public short? DstSubTrnLp { get; set; }

    public short? DstTwrTyp { get; set; }

    public int? DstTwrFirma { get; set; }

    public int? DstTwrNumer { get; set; }

    public short? DstTwrLp { get; set; }

    public decimal? DstKsiegowaNetto { get; set; }

    public decimal? DstKsiegowaBrutto { get; set; }

    public decimal? DstRzeczywistaNetto { get; set; }

    public decimal? DstKosztKsiegowy { get; set; }

    public decimal? DstKosztRzeczywisty { get; set; }

    public string? DstCecha { get; set; }

    public string? DstEan { get; set; }

    public int? DstDataW { get; set; }

    public decimal? DstIlosc { get; set; }

    public int? DstDstTstamp { get; set; }

    public string? DstPolozenie { get; set; }

    public short? DstCcktyp { get; set; }

    public int? DstCckfirma { get; set; }

    public int? DstCcknumer { get; set; }

    public short? DstCcklp { get; set; }

    public decimal? DstWspFin { get; set; }

    public byte? DstKosztUstalono { get; set; }

    public int? DstTpAid { get; set; }

    public int? DstZewnetrznySys { get; set; }

    public int? DstZewnetrznyId { get; set; }

    public byte? DstOplataSpozFlaga { get; set; }

    public virtual ICollection<DstOpisy> DstOpisies { get; set; } = new List<DstOpisy>();

    public virtual ICollection<TwrPromocje> DprTprs { get; set; } = new List<TwrPromocje>();
}
