using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class Kontum
{
    public short? KksGidtyp { get; set; }

    public int? KksGidfirma { get; set; }

    public int KksGidnumer { get; set; }

    public short? KksGidlp { get; set; }

    public short? KksRok { get; set; }

    public short? KksMiesiac { get; set; }

    public string? KksKonto { get; set; }

    public int? KksSynNumer { get; set; }

    public string? KksSubKonto { get; set; }

    public string? KksNazwa { get; set; }

    public string? KksNazwa2 { get; set; }

    public byte? KksPoziom { get; set; }

    public int? KksDataZal { get; set; }

    public byte? KksRozrachunkowe { get; set; }

    public byte? KksPozabilansowe { get; set; }

    public byte? KksTypKonta { get; set; }

    public string? KksWaluta { get; set; }

    public byte? KksKontrola { get; set; }

    public byte? KksPoziomUprawnien { get; set; }

    public string? KksKzkonto { get; set; }

    public byte? KksLokalne { get; set; }

    public int? KksTstamp { get; set; }

    public byte? KksSaldoWgObr { get; set; }

    public decimal? KksBodebet { get; set; }

    public decimal? KksBocredit { get; set; }

    public byte? KksAnalityka { get; set; }

    public short? KksKlasa { get; set; }

    public short? KksKnttyp { get; set; }

    public int? KksKntfirma { get; set; }

    public int? KksKntnumer { get; set; }

    public short? KksKntlp { get; set; }

    public string? KksKontoOrd { get; set; }

    public int? KksOkresId { get; set; }

    public int? KksCzasModyfikacji { get; set; }

    public int? KksOpeNumer { get; set; }

    public int? KksOpeZaklNumer { get; set; }

    public string? KksNastKonto { get; set; }

    public byte? KksNastTyp { get; set; }

    public int? KksNastNumer { get; set; }

    public byte? KksAktualizujPodrz { get; set; }

    public int? KksAktywny { get; set; }

    public byte? KksArchiwalny { get; set; }

    public int? KksKkzdkksnumer { get; set; }

    public int? KksZestZnacznik1 { get; set; }

    public int? KksZestZnacznik2 { get; set; }

    public int? KksZestZnacznikPod { get; set; }

    public virtual Okresy? KksOkres { get; set; }

    public virtual ICollection<KontaNazwy> KontaNazwies { get; set; } = new List<KontaNazwy>();
}
