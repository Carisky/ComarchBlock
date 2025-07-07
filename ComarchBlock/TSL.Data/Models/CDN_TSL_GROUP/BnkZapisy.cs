using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class BnkZapisy
{
    public int BzpBzpId { get; set; }

    public short? BzpRelTyp { get; set; }

    public int? BzpRelId { get; set; }

    public int? BzpBrpId { get; set; }

    public int BzpBrpLp { get; set; }

    public int? BzpBraId { get; set; }

    public short BzpTyp { get; set; }

    public int? BzpKkrId { get; set; }

    public string BzpKartaNr { get; set; } = null!;

    public DateTime? BzpKartaDw { get; set; }

    public int? BzpDdfId { get; set; }

    public int BzpNumerNr { get; set; }

    public string BzpNumerString { get; set; } = null!;

    public string? BzpNumerPelny { get; set; }

    public string BzpNumerObcy { get; set; } = null!;

    public string? BzpNumer { get; set; }

    public short? BzpPodmiotTyp { get; set; }

    public int? BzpPodmiotId { get; set; }

    public int BzpPodmiotRachunekLp { get; set; }

    public int? BzpUraId { get; set; }

    public int? BzpBnaId { get; set; }

    public string BzpRachunekNr { get; set; } = null!;

    public short BzpIban { get; set; }

    public string BzpNazwa1 { get; set; } = null!;

    public string BzpNazwa2 { get; set; } = null!;

    public string BzpNazwa3 { get; set; } = null!;

    public string BzpKraj { get; set; } = null!;

    public string BzpWojewodztwo { get; set; } = null!;

    public string BzpPowiat { get; set; } = null!;

    public string BzpGmina { get; set; } = null!;

    public string BzpUlica { get; set; } = null!;

    public string BzpNrDomu { get; set; } = null!;

    public string BzpNrLokalu { get; set; } = null!;

    public string BzpMiasto { get; set; } = null!;

    public string BzpKodPocztowy { get; set; } = null!;

    public string BzpPoczta { get; set; } = null!;

    public string BzpAdres2 { get; set; } = null!;

    public int? BzpKatId { get; set; }

    public DateTime BzpDataDok { get; set; }

    public decimal BzpKwotaSys { get; set; }

    public decimal BzpKwotaRozSys { get; set; }

    public decimal BzpKwotaRozSysMw { get; set; }

    public DateTime? BzpDataRoz { get; set; }

    public DateTime? BzpDataRozMw { get; set; }

    public decimal BzpKwota { get; set; }

    public decimal BzpKwotaRoz { get; set; }

    public decimal BzpKwotaRozMw { get; set; }

    public string BzpWaluta { get; set; } = null!;

    public string BzpWalutaDok { get; set; } = null!;

    public int BzpKursNumer { get; set; }

    public decimal BzpKursL { get; set; }

    public decimal BzpKursM { get; set; }

    public short BzpKierunek { get; set; }

    public short BzpRozliczono { get; set; }

    public short BzpRozliczonoMw { get; set; }

    public short BzpRozliczono2 { get; set; }

    public short BzpRozliczono2Mw { get; set; }

    public DateTime BzpDataKur { get; set; }

    public string BzpOpis { get; set; } = null!;

    public short BzpZapisAutomatyczny { get; set; }

    public byte BzpImportowany { get; set; }

    public short BzpAutoOffLine { get; set; }

    public string BzpKontoPrzeciwstawne { get; set; } = null!;

    public short BzpMagazynWalut { get; set; }

    public short BzpWgKursuMw { get; set; }

    public byte BzpWynagrodzenie { get; set; }

    public int BzpKolumnaKpr { get; set; }

    public int? BzpKprid { get; set; }

    public DateTime? BzpTsExport { get; set; }

    public string? BzpImportAppId { get; set; }

    public string? BzpImportRowId { get; set; }

    public int BzpTypDokumentuKb { get; set; }

    public int? BzpZakId { get; set; }

    public byte? BzpCdc { get; set; }

    public string? BzpCdcidentPrzelewuBank { get; set; }

    public string? BzpCdcbnkAddInfo { get; set; }

    public string? BzpCdcopis { get; set; }

    public byte BzpSplitPay { get; set; }

    public byte BzpSplitPayZapisVat { get; set; }

    public string? BzpExpImpId { get; set; }

    public int? BzpOpeZalId { get; set; }

    public int? BzpStaZalId { get; set; }

    public DateTime BzpTsZal { get; set; }

    public int? BzpOpeModId { get; set; }

    public int? BzpStaModId { get; set; }

    public DateTime BzpTsMod { get; set; }

    public string BzpOpeModKod { get; set; } = null!;

    public string BzpOpeModNazwisko { get; set; } = null!;

    public string BzpOpeZalKod { get; set; } = null!;

    public string BzpOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<BnkZapisyCdcsepainfo> BnkZapisyCdcsepainfos { get; set; } = new List<BnkZapisyCdcsepainfo>();

    public virtual BnkNazwy? BzpBna { get; set; }

    public virtual BnkRachunki? BzpBra { get; set; }

    public virtual BnkRaporty? BzpBrp { get; set; }

    public virtual DokDefinicje? BzpDdf { get; set; }

    public virtual Kategorie? BzpKat { get; set; }

    public virtual KartyKredytowe? BzpKkr { get; set; }

    public virtual UrzRachunki? BzpUra { get; set; }

    public virtual PodmiotyView? PodmiotyView { get; set; }

    public virtual ICollection<Zaliczki> Zaliczkis { get; set; } = new List<Zaliczki>();
}
