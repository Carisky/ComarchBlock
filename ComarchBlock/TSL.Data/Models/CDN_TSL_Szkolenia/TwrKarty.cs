using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class TwrKarty
{
    public short? TwrGidtyp { get; set; }

    public int? TwrGidfirma { get; set; }

    public int? TwrGidnumer { get; set; }

    public short? TwrGidlp { get; set; }

    public int TwrTyp { get; set; }

    public string TwrKod { get; set; } = null!;

    public string TwrKodFormat { get; set; } = null!;

    public string TwrFppkod { get; set; } = null!;

    public string TwrNazwa { get; set; } = null!;

    public string TwrNazwa1 { get; set; } = null!;

    public string TwrCertyfikat { get; set; } = null!;

    public string TwrSww { get; set; } = null!;

    public string TwrEan { get; set; } = null!;

    public string TwrJm { get; set; } = null!;

    public int TwrWaga { get; set; }

    public string TwrWjm { get; set; } = null!;

    public int TwrJmFormat { get; set; }

    public decimal TwrIloscZam { get; set; }

    public decimal TwrIloscMin { get; set; }

    public decimal TwrIloscMax { get; set; }

    public int TwrUbytek { get; set; }

    public byte TwrProg { get; set; }

    public byte TwrUpust { get; set; }

    public byte TwrUpustData { get; set; }

    public int? TwrUpustDataOd { get; set; }

    public int? TwrUpustDataDo { get; set; }

    public byte TwrUpustGodz { get; set; }

    public int? TwrUpustGodzOd { get; set; }

    public int? TwrUpustGodzDo { get; set; }

    public int TwrAutoZam { get; set; }

    public int TwrIloscAzam { get; set; }

    public int TwrCzasDst { get; set; }

    public int? TwrCenaSpr { get; set; }

    public int TwrJmDomyslna { get; set; }

    public int TwrJmdomyslnaZak { get; set; }

    public int TwrDstDomyslny { get; set; }

    public int TwrRozliczMag { get; set; }

    public int TwrZakup { get; set; }

    public int TwrSprzedaz { get; set; }

    public string? TwrGrupaPod { get; set; }

    public int TwrAkcyza { get; set; }

    public int TwrOpeTyp { get; set; }

    public int TwrOpeFirma { get; set; }

    public int TwrOpeNumer { get; set; }

    public int TwrOpeLp { get; set; }

    public int TwrPrcTyp { get; set; }

    public int TwrPrcFirma { get; set; }

    public int TwrPrcNumer { get; set; }

    public int TwrPrcLp { get; set; }

    public int TwrKontaktTyp { get; set; }

    public int TwrKontaktZa { get; set; }

    public int TwrKontaktJc { get; set; }

    public int TwrOkresowy { get; set; }

    public string TwrCel { get; set; } = null!;

    public string TwrAtrybut1 { get; set; } = null!;

    public int TwrFormat1 { get; set; }

    public string TwrWartosc1 { get; set; } = null!;

    public string TwrAtrybut2 { get; set; } = null!;

    public int TwrFormat2 { get; set; }

    public string TwrWartosc2 { get; set; } = null!;

    public string TwrAtrybut3 { get; set; } = null!;

    public int TwrFormat3 { get; set; }

    public string TwrWartosc3 { get; set; } = null!;

    public int TwrPunkty { get; set; }

    public int TwrKoncesja { get; set; }

    public string TwrKonto1 { get; set; } = null!;

    public string TwrKonto2 { get; set; } = null!;

    public string TwrKonto3 { get; set; } = null!;

    public string TwrPolozenie { get; set; } = null!;

    public string TwrKatalog { get; set; } = null!;

    public byte TwrWcenniku { get; set; }

    public byte TwrEdycjaNazwy { get; set; }

    public byte TwrBezRabatu { get; set; }

    public byte TwrKopiujOpis { get; set; }

    public string TwrUrl { get; set; } = null!;

    public string TwrWarunek { get; set; } = null!;

    public int TwrObjetoscL { get; set; }

    public int TwrObjetoscM { get; set; }

    public int TwrLastModL { get; set; }

    public int TwrLastModO { get; set; }

    public int TwrLastModC { get; set; }

    public int TwrTerminZwrotu { get; set; }

    public int TwrZakupAutoryz { get; set; }

    public int TwrMagTyp { get; set; }

    public int TwrMagFirma { get; set; }

    public int TwrMagNumer { get; set; }

    public int TwrMagLp { get; set; }

    public decimal TwrMarzaMin { get; set; }

    public decimal TwrKosztUslugi { get; set; }

    public byte TwrKosztUtyp { get; set; }

    public int TwrClo { get; set; }

    public int TwrPodatekImp { get; set; }

    public int TwrStanInfoLimit { get; set; }

    public int TwrStanInfoMax { get; set; }

    public int TwrStanInfoProcent { get; set; }

    public int TwrAktywna { get; set; }

    public int TwrWsk { get; set; }

    public int TwrCcktyp { get; set; }

    public int TwrCckfirma { get; set; }

    public int TwrCcknumer { get; set; }

    public int TwrCcklp { get; set; }

    public int TwrPrdTyp { get; set; }

    public int TwrPrdFirma { get; set; }

    public int TwrPrdNumer { get; set; }

    public int TwrPrdLp { get; set; }

    public int TwrOpeTypM { get; set; }

    public int TwrOpeFirmaM { get; set; }

    public int TwrOpeNumerM { get; set; }

    public int TwrOpeLpM { get; set; }

    public string TwrPcn { get; set; } = null!;

    public int TwrNotowania { get; set; }

    public int TwrWagaBrutto { get; set; }

    public string TwrWjmBrutto { get; set; } = null!;

    public string? TwrGrupaPodSpr { get; set; }

    public int TwrLicencja { get; set; }

    public int TwrBlokada { get; set; }
}
