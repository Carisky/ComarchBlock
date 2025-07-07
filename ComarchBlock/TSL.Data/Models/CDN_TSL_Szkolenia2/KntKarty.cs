using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class KntKarty
{
    public short? KntGidtyp { get; set; }

    public int? KntGidfirma { get; set; }

    public int? KntGidnumer { get; set; }

    public short? KntGidlp { get; set; }

    public int KntKnAtyp { get; set; }

    public int KntKnAfirma { get; set; }

    public int KntKnAnumer { get; set; }

    public int KntKnAlp { get; set; }

    public int KntTyp { get; set; }

    public int KntAkwizytor { get; set; }

    public string KntAkronim { get; set; } = null!;

    public string KntAkronimFormat { get; set; } = null!;

    public string KntFppKod { get; set; } = null!;

    public string KntNazwa1 { get; set; } = null!;

    public string KntNazwa2 { get; set; } = null!;

    public string KntNazwa3 { get; set; } = null!;

    public string KntKodP { get; set; } = null!;

    public string KntMiasto { get; set; } = null!;

    public string? KntUlica { get; set; }

    public string KntAdres { get; set; } = null!;

    public string KntNipE { get; set; } = null!;

    public string KntNip { get; set; } = null!;

    public string KntRegon { get; set; } = null!;

    public string KntPesel { get; set; } = null!;

    public string KntKontoDostawcy { get; set; } = null!;

    public string KntKontoOdbiorcy { get; set; } = null!;

    public string KntKraj { get; set; } = null!;

    public string KntTelefon1 { get; set; } = null!;

    public string KntTelefon2 { get; set; } = null!;

    public string KntFax { get; set; } = null!;

    public string KntModem { get; set; } = null!;

    public string KntTelex { get; set; } = null!;

    public string KntEmail { get; set; } = null!;

    public string KntUrl { get; set; } = null!;

    public short? KntBnkTyp { get; set; }

    public int? KntBnkFirma { get; set; }

    public int? KntBnkNumer { get; set; }

    public short? KntBnkLp { get; set; }

    public string KntNrRachunku { get; set; } = null!;

    public string KntSoundex { get; set; } = null!;

    public decimal KntRabat { get; set; }

    public int KntLimitWart { get; set; }

    public int KntMaxLimitWart { get; set; }

    public int KntLimitPoTerminie { get; set; }

    public int KntLimitOkres { get; set; }

    public int KntDewizowe { get; set; }

    public string KntSymbol { get; set; } = null!;

    public int KntNrKursu { get; set; }

    public short KntCena { get; set; }

    public int? KntFormaPl { get; set; }

    public int? KntFormaplzak { get; set; }

    public int KntMarza { get; set; }

    public int KntTypKarty { get; set; }

    public string KntNumerKarty { get; set; } = null!;

    public int KntDataKarty { get; set; }

    public string KntEan { get; set; } = null!;

    public int KntObcaKarta { get; set; }

    public int KntEanTyp { get; set; }

    public int KntEanFirma { get; set; }

    public int KntEanNumer { get; set; }

    public int KntOsoba { get; set; }

    public byte KntExpoKraj { get; set; }

    public string KntSeriaFa { get; set; } = null!;

    public byte KntPlatnikVat { get; set; }

    public int KntTypDok { get; set; }

    public int KntStatus { get; set; }

    public int KntKoncesja { get; set; }

    public int KntDataKoncesji { get; set; }

    public int KntFavatdata { get; set; }

    public int KntSposobDostawy { get; set; }

    public string KntHasloChk { get; set; } = null!;

    public string KntHasloKontrahent { get; set; } = null!;

    public int KntDzialalnosc { get; set; }

    public int KntZtrTyp { get; set; }

    public int KntZtrFirma { get; set; }

    public int KntZtrNumer { get; set; }

    public int KntZtrLp { get; set; }

    public int KntOpeTyp { get; set; }

    public int KntOpeFirma { get; set; }

    public int KntOpeNumer { get; set; }

    public int KntOpeLp { get; set; }

    public int KntAkwTyp { get; set; }

    public int KntAkwFirma { get; set; }

    public int KntAkwNumer { get; set; }

    public int KntAkwLp { get; set; }

    public int KntPrcTyp { get; set; }

    public int KntPrcFirma { get; set; }

    public int KntPrcNumer { get; set; }

    public int KntPrcLp { get; set; }

    public string KntAtrybut1 { get; set; } = null!;

    public int KntFormat1 { get; set; }

    public string KntWartosc1 { get; set; } = null!;

    public string KntAtrybut2 { get; set; } = null!;

    public int KntFormat2 { get; set; }

    public string KntWartosc2 { get; set; } = null!;

    public string KntAtrybut3 { get; set; } = null!;

    public int KntFormat3 { get; set; }

    public string KntWartosc3 { get; set; } = null!;

    public int KntAkwProwizja { get; set; }

    public string KntUmowa { get; set; } = null!;

    public int KntDataW { get; set; }

    public int KntLastModL { get; set; }

    public int KntLastModO { get; set; }

    public int KntLastModC { get; set; }

    public string KntFaVatosw { get; set; } = null!;

    public string KntCechaOpis { get; set; } = null!;

    public int KntAutoPotwierdzenie { get; set; }

    public int KntAktywna { get; set; }

    public int KntWsk { get; set; }

    public int KntMagTyp { get; set; }

    public int KntMagFirma { get; set; }

    public int KntMagNumer { get; set; }

    public int KntMagLp { get; set; }

    public string KntOutlookUrl { get; set; } = null!;

    public byte KntNieaktywny { get; set; }

    public int KntZrodlo { get; set; }

    public int KntBranza { get; set; }

    public int KntRodzaj { get; set; }

    public int KntRolaPartnera { get; set; }

    public int KntOdleglosc { get; set; }

    public int KntKarTyp { get; set; }

    public int KntKarFirma { get; set; }

    public int KntKarNumer { get; set; }

    public int KntKarLp { get; set; }

    public short? KntKnPtyp { get; set; }

    public int? KntKnPnumer { get; set; }

    public int KntKnPparam { get; set; }
}
