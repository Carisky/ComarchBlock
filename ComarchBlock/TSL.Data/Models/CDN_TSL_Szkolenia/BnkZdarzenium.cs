using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class BnkZdarzenium
{
    public int BzdBzdId { get; set; }

    public short? BzdRelTyp { get; set; }

    public int? BzdRelId { get; set; }

    public short? BzdPrwTyp { get; set; }

    public int? BzdPrwId { get; set; }

    public int? BzdBraId { get; set; }

    public int? BzdDdfId { get; set; }

    public short? BzdDokumentTyp { get; set; }

    public int? BzdDokumentId { get; set; }

    public string BzdNumerPelny { get; set; } = null!;

    public string BzdNumerObcy { get; set; } = null!;

    public string? BzdNumer { get; set; }

    public short BzdPodmiotTyp { get; set; }

    public int BzdPodmiotId { get; set; }

    public int BzdPodmiotRachunekLp { get; set; }

    public int? BzdUraId { get; set; }

    public int? BzdBnaId { get; set; }

    public string BzdRachunekNr { get; set; } = null!;

    public short BzdIban { get; set; }

    public int? BzdKatId { get; set; }

    public int? BzdFplId { get; set; }

    public DateTime BzdDataDok { get; set; }

    public DateTime BzdTermin { get; set; }

    public DateTime? BzdTerminR { get; set; }

    public DateTime BzdDataReal { get; set; }

    public DateTime? BzdDataWys { get; set; }

    public decimal BzdKwotaSys { get; set; }

    public decimal BzdKwotaRozSys { get; set; }

    public decimal BzdKwota { get; set; }

    public decimal BzdKwotaRoz { get; set; }

    public string BzdWaluta { get; set; } = null!;

    public string BzdWalutaDok { get; set; } = null!;

    public int BzdKursNumer { get; set; }

    public decimal BzdKursL { get; set; }

    public decimal BzdKursM { get; set; }

    public DateTime? BzdDataRoz { get; set; }

    public short BzdKierunek { get; set; }

    public DateTime BzdDataKur { get; set; }

    public short BzdZwloka { get; set; }

    public short BzdPriorytet { get; set; }

    public short BzdRozliczono { get; set; }

    public short BzdRozliczono2 { get; set; }

    public short BzdStan { get; set; }

    public byte BzdNieNaliczajOdsetek { get; set; }

    public string BzdElixirO1 { get; set; } = null!;

    public string BzdElixirO2 { get; set; } = null!;

    public string BzdElixirO3 { get; set; } = null!;

    public string BzdElixirO4 { get; set; } = null!;

    public string BzdOpis { get; set; } = null!;

    public string BzdKontoPrzeciwstawne { get; set; } = null!;

    public int? BzdOpeWysId { get; set; }

    public DateTime? BzdTsWys { get; set; }

    public int? BzdOpePotwId { get; set; }

    public DateTime? BzdTsPotw { get; set; }

    public DateTime? BzdTsExport { get; set; }

    public string? BzdImportAppId { get; set; }

    public string? BzdImportRowId { get; set; }

    public int? BzdIdSynchro { get; set; }

    public int BzdTypDokumentuKb { get; set; }

    public int? BzdOpeZalId { get; set; }

    public string? BzdCdcident { get; set; }

    public string? BzdCdcidentPrzelewuBank { get; set; }

    public DateTime? BzdCdcdataWyslania { get; set; }

    public int? BzdCdcopeId { get; set; }

    public string? BzdCdckodKomunikatu { get; set; }

    public string? BzdCdckomunikat { get; set; }

    public DateTime? BzdCdcdataKomunikatu { get; set; }

    public string? BzdCdcsendPaymentsXmlrequest { get; set; }

    public byte BzdPrzelewSepa { get; set; }

    public short? BzdSrw { get; set; }

    public int? BzdWindykacjaSchematId { get; set; }

    public byte BzdKomornikZajecieWynagr { get; set; }

    public byte BzdSplitPay { get; set; }

    public string? BzdSplitPayNipE { get; set; }

    public decimal? BzdSplitPayKwotaVat { get; set; }

    public string? BzdSplitPayNrDok { get; set; }

    public string? BzdWeryfRachIdOdpytania { get; set; }

    public byte? BzdApfinoStat { get; set; }

    public string? BzdApfinoLink { get; set; }

    public string? BzdApfinoLinkPayLater { get; set; }

    public string? BzdExpImpId { get; set; }

    public int? BzdStaZalId { get; set; }

    public DateTime BzdTsZal { get; set; }

    public int? BzdStaModId { get; set; }

    public int? BzdOpeModId { get; set; }

    public DateTime BzdTsMod { get; set; }

    public string BzdOpeModKod { get; set; } = null!;

    public string BzdOpeModNazwisko { get; set; } = null!;

    public string BzdOpeZalKod { get; set; } = null!;

    public string BzdOpeZalNazwisko { get; set; } = null!;

    public string? BzdCdcsendPaymentsTaskId { get; set; }

    public byte BzdAutoWindBlokadaSprzed { get; set; }

    public virtual ICollection<BnkZdarzeniaAutoryzacje> BnkZdarzeniaAutoryzacjes { get; set; } = new List<BnkZdarzeniaAutoryzacje>();

    public virtual ICollection<BnkZdarzeniaCdcsepainfo> BnkZdarzeniaCdcsepainfos { get; set; } = new List<BnkZdarzeniaCdcsepainfo>();

    public virtual ICollection<BnkZdarzeniaPodpisy> BnkZdarzeniaPodpisies { get; set; } = new List<BnkZdarzeniaPodpisy>();

    public virtual BnkNazwy? BzdBna { get; set; }

    public virtual BnkRachunki? BzdBra { get; set; }

    public virtual DokDefinicje? BzdDdf { get; set; }

    public virtual FormyPlatnosci? BzdFpl { get; set; }

    public virtual Kategorie? BzdKat { get; set; }

    public virtual UrzRachunki? BzdUra { get; set; }

    public virtual ICollection<NotyOdsElem> NotyOdsElems { get; set; } = new List<NotyOdsElem>();

    public virtual PodmiotyView PodmiotyView { get; set; } = null!;
}
