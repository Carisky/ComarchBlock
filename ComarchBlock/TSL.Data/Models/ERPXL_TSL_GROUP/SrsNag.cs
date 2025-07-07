using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SrsNag
{
    public short SsNGidtyp { get; set; }

    public int SsNGidFirma { get; set; }

    public int SsNGidnumer { get; set; }

    public short SsNGidlp { get; set; }

    public short? SsNKntTyp { get; set; }

    public int? SsNKntFirma { get; set; }

    public int? SsNKntNumer { get; set; }

    public short? SsNKntLp { get; set; }

    public short? SsNOsobaLp { get; set; }

    public short? SsNAkwTyp { get; set; }

    public int? SsNAkwFirma { get; set; }

    public int? SsNAkwNumer { get; set; }

    public short? SsNAkwLp { get; set; }

    public short? SsNAkwOsobaLp { get; set; }

    public string? SsNStreszczenie { get; set; }

    public short? SsNArtTyp { get; set; }

    public int? SsNArtFirma { get; set; }

    public int? SsNArtNumer { get; set; }

    public short? SsNArtLp { get; set; }

    public int? SsNRodzaj { get; set; }

    public byte? SsNOplata { get; set; }

    public int? SsNTstampDataStart { get; set; }

    public int? SsNTstampDataStop { get; set; }

    public byte? SsNPriorytet { get; set; }

    public string? SsNOpis { get; set; }

    public short? SsNTwXtyp { get; set; }

    public int? SsNTwXfirma { get; set; }

    public int? SsNTwXnumer { get; set; }

    public short? SsNTwXlp { get; set; }

    public string? SsNWersja { get; set; }

    public string? SsNAtrybut1 { get; set; }

    public byte? SsNFormat1 { get; set; }

    public string? SsNWartosc1 { get; set; }

    public string? SsNAtrybut2 { get; set; }

    public byte? SsNFormat2 { get; set; }

    public string? SsNWartosc2 { get; set; }

    public string? SsNAtrybut3 { get; set; }

    public byte? SsNFormat3 { get; set; }

    public string? SsNWartosc3 { get; set; }

    public short? SsNTrnTyp { get; set; }

    public int? SsNTrnFirma { get; set; }

    public int? SsNTrnNumer { get; set; }

    public short? SsNTrnLp { get; set; }

    public short? SsNOpeTyp { get; set; }

    public int? SsNOpeFirma { get; set; }

    public int? SsNOpeNumer { get; set; }

    public short? SsNOpeLp { get; set; }

    public short? SsNOpeStartTyp { get; set; }

    public int? SsNOpeStartFirma { get; set; }

    public int? SsNOpeStartNumer { get; set; }

    public short? SsNOpeStartLp { get; set; }

    public short? SsNOpeStopTyp { get; set; }

    public int? SsNOpeStopFirma { get; set; }

    public int? SsNOpeStopNumer { get; set; }

    public short? SsNOpeStopLp { get; set; }

    public int? SsNRokMiesiac { get; set; }

    public virtual ICollection<SrsElem> SrsElems { get; set; } = new List<SrsElem>();

    public virtual ICollection<CrmkntEtapy> CkwCeks { get; set; } = new List<CrmkntEtapy>();
}
