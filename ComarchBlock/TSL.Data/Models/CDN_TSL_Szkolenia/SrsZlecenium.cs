using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class SrsZlecenium
{
    public int SrZSrZid { get; set; }

    public int SrZDdfId { get; set; }

    public int? SrZKatId { get; set; }

    public string SrZNumerString { get; set; } = null!;

    public int SrZNumerNr { get; set; }

    public string? SrZNumerPelny { get; set; }

    public short SrZBufor { get; set; }

    public short SrZStan { get; set; }

    public string SrZDokStatus { get; set; } = null!;

    public short? SrZPodmiotTyp { get; set; }

    public int? SrZPodmiotId { get; set; }

    public string SrZPodNazwa1 { get; set; } = null!;

    public string SrZPodNazwa2 { get; set; } = null!;

    public string SrZPodNazwa3 { get; set; } = null!;

    public string SrZPodKraj { get; set; } = null!;

    public string SrZPodWojewodztwo { get; set; } = null!;

    public string SrZPodPowiat { get; set; } = null!;

    public string SrZPodGmina { get; set; } = null!;

    public string SrZPodUlica { get; set; } = null!;

    public string SrZPodNrDomu { get; set; } = null!;

    public string SrZPodNrLokalu { get; set; } = null!;

    public string SrZPodMiasto { get; set; } = null!;

    public string SrZPodKodPocztowy { get; set; } = null!;

    public string SrZPodPoczta { get; set; } = null!;

    public string SrZPodAdres2 { get; set; } = null!;

    public string SrZTelefon { get; set; } = null!;

    public string SrZEmail { get; set; } = null!;

    public short? SrZOdbiorcaTyp { get; set; }

    public int? SrZOdbId { get; set; }

    public string SrZOdbNazwa1 { get; set; } = null!;

    public string SrZOdbNazwa2 { get; set; } = null!;

    public string SrZOdbNazwa3 { get; set; } = null!;

    public string SrZOdbKraj { get; set; } = null!;

    public string SrZOdbWojewodztwo { get; set; } = null!;

    public string SrZOdbPowiat { get; set; } = null!;

    public string SrZOdbGmina { get; set; } = null!;

    public string SrZOdbUlica { get; set; } = null!;

    public string SrZOdbNrDomu { get; set; } = null!;

    public string SrZOdbNrLokalu { get; set; } = null!;

    public string SrZOdbMiasto { get; set; } = null!;

    public string SrZOdbKodPocztowy { get; set; } = null!;

    public string SrZOdbPoczta { get; set; } = null!;

    public string SrZOdbAdres2 { get; set; } = null!;

    public string SrZOdbTelefon { get; set; } = null!;

    public string SrZOdbEmail { get; set; } = null!;

    public int? SrZZlecajacyId { get; set; }

    public string SrZZlecajacyNazwisko { get; set; } = null!;

    public string? SrZZlecajacyTelefon { get; set; }

    public int? SrZPrzedstawicielId { get; set; }

    public string? SrZPrzedstawicielNazwisko { get; set; }

    public string? SrZPrzedstawicielTelefon { get; set; }

    public short? SrZProwadzacyTyp { get; set; }

    public int? SrZProwadzacyId { get; set; }

    public byte SrZPriorytet { get; set; }

    public int? SrZSrUid { get; set; }

    public DateTime SrZDataDok { get; set; }

    public DateTime? SrZDataPrzyjecia { get; set; }

    public DateTime? SrZDataRealizacji { get; set; }

    public DateTime? SrZCzasRealizacji { get; set; }

    public DateTime? SrZDataZamkniecia { get; set; }

    public int? SrZMagId { get; set; }

    public int? SrZEtapId { get; set; }

    public string? SrZEtapOpis { get; set; }

    public DateTime? SrZEtapData { get; set; }

    public decimal SrZWykonano { get; set; }

    public string SrZOpis { get; set; } = null!;

    public byte SrZTypNb { get; set; }

    public decimal SrZWartoscNetto { get; set; }

    public decimal SrZWartoscBrutto { get; set; }

    public decimal SrZWartoscNettoDoFa { get; set; }

    public decimal SrZWartoscBruttoDoFa { get; set; }

    public int SrZCzasRealizacjiCzynnosci { get; set; }

    public byte SrZZbiorczeFaCzesci { get; set; }

    public int? SrZZbiorczeTwrIdCzesci { get; set; }

    public byte SrZZbiorczeFaCzynnosci { get; set; }

    public int? SrZZbiorczeTwrIdCzynnosci { get; set; }

    public string SrZWaluta { get; set; } = null!;

    public int SrZKursNumer { get; set; }

    public decimal SrZKursL { get; set; }

    public decimal SrZKursM { get; set; }

    public DateTime SrZDataKur { get; set; }

    public decimal SrZWartoscNettoDoFapln { get; set; }

    public decimal SrZWartoscBruttoDoFapln { get; set; }

    public decimal SrZWartoscNettoPln { get; set; }

    public decimal SrZWartoscBruttoPln { get; set; }

    public byte SrZFplTyp { get; set; }

    public int? SrZFplId { get; set; }

    public byte SrZTerminPlatTyp { get; set; }

    public DateTime? SrZTerminPlatData { get; set; }

    public int? SrZOpeZalId { get; set; }

    public int? SrZStaZalId { get; set; }

    public DateTime SrZTsZal { get; set; }

    public int? SrZOpeModId { get; set; }

    public int? SrZStaModId { get; set; }

    public DateTime SrZTsMod { get; set; }

    public string SrZOpeModKod { get; set; } = null!;

    public string SrZOpeModNazwisko { get; set; } = null!;

    public string SrZOpeZalKod { get; set; } = null!;

    public string SrZOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<DokAtrybuty> DokAtrybuties { get; set; } = new List<DokAtrybuty>();

    public virtual PodmiotyView? PodmiotyView { get; set; }

    public virtual PodmiotyView? PodmiotyViewNavigation { get; set; }

    public virtual Kategorie? SrZKat { get; set; }

    public virtual Magazyny? SrZMag { get; set; }

    public virtual KntOsoby? SrZZlecajacy { get; set; }

    public virtual ICollection<SrsCzesci> SrsCzescis { get; set; } = new List<SrsCzesci>();

    public virtual ICollection<SrsCzynnosci> SrsCzynnoscis { get; set; } = new List<SrsCzynnosci>();

    public virtual ICollection<SrsNotatki> SrsNotatkis { get; set; } = new List<SrsNotatki>();

    public virtual ICollection<TwrAtrybuty> TwrAtrybuties { get; set; } = new List<TwrAtrybuty>();
}
