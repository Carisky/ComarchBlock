using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class Zapisy
{
    public short? KazGidtyp { get; set; }

    public int? KazGidfirma { get; set; }

    public int KazGidnumer { get; set; }

    public short? KazGidlp { get; set; }

    public short? KazKrptyp { get; set; }

    public int? KazKrpfirma { get; set; }

    public int? KazKrpnumer { get; set; }

    public int? KazKrplp { get; set; }

    public short? KazRok { get; set; }

    public string? KazSeria { get; set; }

    public int? KazNumerKwitu { get; set; }

    public string? KazNumerDokumentu { get; set; }

    public string? KazNrRachunku { get; set; }

    public short? KazKaotyp { get; set; }

    public int? KazKaofirma { get; set; }

    public int? KazKaonumer { get; set; }

    public short? KazKaolp { get; set; }

    public short? KazKnttyp { get; set; }

    public int? KazKntfirma { get; set; }

    public int? KazKntnumer { get; set; }

    public short? KazKntlp { get; set; }

    public string? KazKontoPrzec { get; set; }

    public string? KazKontoPrzecR { get; set; }

    public int? KazDataZapisu { get; set; }

    public int? KazDataDokumentu { get; set; }

    public byte? KazRp { get; set; }

    public byte? KazZnak { get; set; }

    public decimal? KazKwota { get; set; }

    public decimal? KazPozostaje { get; set; }

    public string? KazWaluta { get; set; }

    public short? KazNrKursu { get; set; }

    public decimal? KazKursL { get; set; }

    public decimal? KazKursM { get; set; }

    public byte? KazRozliczony { get; set; }

    public string? KazTresc { get; set; }

    public int? KazTstamp { get; set; }

    public short? KazOpeTypR { get; set; }

    public int? KazOpeFirmaR { get; set; }

    public int? KazOpeNumerR { get; set; }

    public short? KazOpeLpR { get; set; }

    public short? KazOpeTypB { get; set; }

    public int? KazOpeFirmaB { get; set; }

    public int? KazOpeNumerB { get; set; }

    public short? KazOpeLpB { get; set; }

    public string? KazCiagNumeracji { get; set; }

    public byte? KazZaksiegowano { get; set; }

    public int? KazAktywny { get; set; }

    public int? KazIcvtstamp { get; set; }

    public short? KazIcvstatus { get; set; }

    public string? KazIcvnumer { get; set; }

    public string? KazWalutaRoz { get; set; }

    public decimal? KazKwotaRoz { get; set; }

    public decimal? KazPozostajeRoz { get; set; }

    public decimal? KazKwotaSys { get; set; }

    public decimal? KazPozostajeSys { get; set; }

    public decimal? KazPozostajeWycena { get; set; }

    public decimal? KazPozostajeWycenaSys { get; set; }

    public decimal? KazWycenaRk { get; set; }

    public decimal? KazWycenaRkstan { get; set; }

    public int? KazDokId { get; set; }

    public short? KazKndtyp { get; set; }

    public int? KazKndfirma { get; set; }

    public int? KazKndnumer { get; set; }

    public short? KazKndlp { get; set; }

    public string? KazCechaOpis { get; set; }

    public byte? KazZaliczka { get; set; }

    public byte? KazAnulowany { get; set; }

    public int? KazStRidW { get; set; }

    public string? KazOpis { get; set; }

    public short? KazOpetypRm { get; set; }

    public int? KazOpefirmaRm { get; set; }

    public int? KazOpenumerRm { get; set; }

    public short? KazOpelpRm { get; set; }

    public short? KazOpetypBm { get; set; }

    public int? KazOpefirmaBm { get; set; }

    public int? KazOpenumerBm { get; set; }

    public short? KazOpelpBm { get; set; }

    public int? KazTstampM { get; set; }

    public byte? KazStanRealizacji { get; set; }

    public int? KazCzasZapisu { get; set; }

    public short? KazMiesiac { get; set; }

    public int? KazOkrId { get; set; }

    public byte? KazWyceniony { get; set; }

    public byte? KazWycenaKolejnosc { get; set; }

    public byte? KazKursWgWyceny { get; set; }

    public byte? KazWynagrodzenie { get; set; }

    public byte? KazZapisZerujacy { get; set; }

    public byte? KazRaportBo { get; set; }

    public int? KazZewnetrznyId { get; set; }

    public int? KazZewnetrznySys { get; set; }

    public int? KazZewnetrznyTyp { get; set; }

    public byte? KazLokata { get; set; }

    public int? KazLokataTermin { get; set; }

    public int? KazLokataTypId { get; set; }

    public int? KazLokataOtwNumer { get; set; }

    public string? KazLokataNrRachunku { get; set; }

    public byte? KazLokataNrb { get; set; }

    public byte? KazZwyciagu { get; set; }

    public byte? KazCdc { get; set; }

    public string? KazTrescCdc { get; set; }

    public string? KazWirtualnyEq { get; set; }

    public int? KazSplitPnumer { get; set; }

    public string? KazBankKodOperacji { get; set; }

    public string? KazGuid { get; set; }

    public int? KazOperatorPos { get; set; }

    public string? KazKontrahentCdc { get; set; }

    public byte? KazDoWyjasnienia { get; set; }

    public string? KazEndToEndId { get; set; }

    public byte? KazAutoRozliczenie { get; set; }

    public int? KazBbonId { get; set; }

    public byte? KazWtrakciePrzetwarzania { get; set; }

    public decimal? KazKwotaCdc { get; set; }

    public int? KazDataRozliczenia { get; set; }

    public virtual Operacje? Operacje { get; set; }

    public virtual ICollection<Delegacje> DlrDlgnumers { get; set; } = new List<Delegacje>();
}
